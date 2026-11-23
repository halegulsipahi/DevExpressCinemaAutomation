param(
    [string]$Version = '1.0.1',
    [string]$SqlInstance = 'localhost\SQLEXPRESS'
)
$ErrorActionPreference = 'Stop'
$root = Split-Path -Parent $MyInvocation.MyCommand.Path
$solution = Join-Path $root 'DevExpressCinemaAutomation.sln'
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio\Installer\vswhere.exe'
if (!(Test-Path $vswhere)) { throw 'Visual Studio Installer bulunamadi.' }
$vsPath = & $vswhere -latest -products * -requires Microsoft.Component.MSBuild -property installationPath
if (!$vsPath) { throw 'MSBuild bulunamadi.' }
$msbuild = Join-Path $vsPath 'MSBuild\Current\Bin\MSBuild.exe'
if (!(Test-Path $msbuild)) { throw "MSBuild bulunamadi: $msbuild" }
$nuget = Get-Command nuget.exe -ErrorAction SilentlyContinue
if ($nuget) {
    & $nuget.Source restore $solution -NonInteractive
    if ($LASTEXITCODE -ne 0) { throw 'NuGet restore basarisiz.' }
} else { Write-Warning 'nuget.exe yok: Visual Studio icinden Restore NuGet Packages yapin.' }
& $msbuild $solution /t:Rebuild /p:Configuration=Release /p:Platform='Any CPU' /m /v:minimal
if ($LASTEXITCODE -ne 0) { throw 'Release derlemesi basarisiz.' }
$bin = Join-Path $root 'DevExpressCinemaAutomation\bin\Release'
$exe = Join-Path $bin 'DevExpressCinemaAutomation.exe'
if (!(Test-Path $exe)) { throw "EXE bulunamadi: $exe" }
$releaseDir = Join-Path $root 'release'
$bundle = "DevExpressCinemaAutomation-v$Version-win"
$stage = Join-Path $releaseDir $bundle
if (Test-Path $stage) { Remove-Item $stage -Recurse -Force }
New-Item -ItemType Directory -Path $stage -Force | Out-Null
Get-ChildItem -LiteralPath $bin -File | Where-Object { $_.Extension -notin @('.pdb','.xml') } | Copy-Item -Destination $stage -Force
# Ana projede referanslanmayan Business DLL'si dahil katman DLL'lerini dogrudan kendi build ciktisindan al.
foreach ($project in @('CinemaAutomation.Business', 'CinemaAutomation.Entities', 'CinemaAutomation.DataAccess')) {
    $dll = Join-Path $root "$project\bin\Release\$project.dll"
    if (!(Test-Path $dll)) { throw "Katman DLL bulunamadi: $dll" }
    Copy-Item -LiteralPath $dll -Destination $stage -Force
}
$configPath = Join-Path $stage 'DevExpressCinemaAutomation.exe.config'
if (!(Test-Path $configPath)) { throw 'EXE config dosyasi yok.' }
# Dizenin icindeki XML baslangic bosluklarini da temizle; .NET config okuyucusu hassastir.
$configText = [System.IO.File]::ReadAllText($configPath).TrimStart([char]0xFEFF, [char]0x20, [char]0x09, [char]0x0A, [char]0x0D)
[xml]$cfg = $configText
$entry = $cfg.configuration.connectionStrings.add | Where-Object { $_.name -eq 'CinemaEFContext' } | Select-Object -First 1
if (!$entry) { throw 'CinemaEFContext connection string bulunamadi.' }
$builder = New-Object System.Data.SqlClient.SqlConnectionStringBuilder($entry.connectionString)
$builder['Data Source'] = $SqlInstance
$entry.connectionString = $builder.ConnectionString
$cfg.Save($configPath)
[xml]$verified = [System.IO.File]::ReadAllText($configPath)
if ($verified.configuration.connectionStrings.add.connectionString -notmatch [regex]::Escape($SqlInstance)) {
    throw 'SQL instance config dogrulamasi basarisiz.'
}
$required = @('DevExpressCinemaAutomation.exe','DevExpressCinemaAutomation.exe.config', 'CinemaAutomation.DataAccess.dll','CinemaAutomation.Entities.dll','CinemaAutomation.Business.dll','EntityFramework.dll','EntityFramework.SqlServer.dll')
$missing = @($required | Where-Object { !(Test-Path (Join-Path $stage $_)) })
if ($missing.Count -gt 0) { throw ('Eksik paket dosyalari: ' + ($missing -join ', ')) }
$devexpress = @(Get-ChildItem -Path $stage -Filter 'DevExpress*.dll')
if ($devexpress.Count -eq 0) { throw 'DevExpress DLL eksik. Referanslarin Copy Local ayarlarini kontrol edin.' }
New-Item -ItemType Directory -Path (Join-Path $stage 'Posters') -Force | Out-Null
@'
Cinema Automation v1.0.1
Windows: .NET Framework 4.8, SQL Server Express (SQLEXPRESS) gerekli.
ZIP'i tamamen cikartin. Uygulama veritabani ilk acilista olusturmaya calisir;
Windows kullanicinizin SQL Server'da gerekli izni olmalidir.
Farkli SQL instance icin .exe.config icindeki Data Source ayarini duzenleyin.
Yerel SQLEXPRESS verisi diger bilgisayarlarla otomatik paylasilmaz.
Hatalar: %LOCALAPPDATA%\CinemaAutomation\Logs\errors.log
DevExpress DLL dagitim kosullarini lisansinizdan kontrol edin.
'@ | Set-Content -Path (Join-Path $stage 'KURULUM.txt') -Encoding UTF8
$zip = Join-Path $releaseDir "$bundle.zip"
if (Test-Path $zip) { Remove-Item $zip -Force }
Compress-Archive -Path $stage -DestinationPath $zip -CompressionLevel Optimal
Write-Host "Release olusturuldu: $zip" -ForegroundColor Green
Write-Host 'GitHub oncesi temiz Windows bilgisayarinda test edin.'

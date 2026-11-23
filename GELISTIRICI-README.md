# Cinema Automation v1.0.1 – geliştirici düzeltmeleri

Bu ZIP, **tam kaynak proje değil**, mevcut projeye uygulanacak 3 dosyanın güncellenmiş sürümüdür.

## Uygulama
1. Mevcut projeyi Git ile commit edin / yedekleyin.
2. ZIP içindeki `DevExpressCinemaAutomation/App.config` ve `DevExpressCinemaAutomation/Program.cs` dosyalarını **aynı göreli yollardaki** dosyalarla değiştirin.
3. `Build-Release.ps1` dosyasını `.sln` dosyasının yanında konumlandırın.
4. Visual Studio'da **Restore NuGet Packages** yapın ve `Release / Any CPU` derleyin.
5. Developer PowerShell'de `./Build-Release.ps1 -Version 1.0.1 -SqlInstance 'localhost\SQLEXPRESS'` çalıştırın.
6. `release/DevExpressCinemaAutomation-v1.0.1-win.zip` dosyasını temiz Windows bilgisayarında deneyin. SQL Server Express + .NET Framework 4.8 gerekli.
7. Testler geçerse GitHub'da `v1.0.1` Release oluşturun.

## Ne değişti?
- **App.config:** varsayılan SQL sunucusu `localhost\SQLEXPRESS` oldu; veritabanı adı `CinemaAutomationDb` korundu.
- **Program.cs:** başlatma hataları kullanıcıya gösterilir; detaylar `%LOCALAPPDATA%\CinemaAutomation\Logs\errors.log` içinde tutulur. Loglar kişisel/veritabanı bilgisi içerebilir; GitHub'a göndermeyin.
- **Build-Release.ps1:** Business/Entities/DataAccess DLL'leri kendi çıktılarından alır; `config` XML'ini doğrular ve seçilen SQL sunucusunu release config'ine yazar; eski staging klasörünü temizler.

## Kontrol listesi
- Proje Developer bilgisayarında Release modunda hatasız derleniyor mu?
- ZIP içinde 3 katman DLL'si, EntityFramework DLL'leri, DevExpress DLL'leri ve `exe.config` var mı?
- ZIP temiz bilgisayarda açılıyor mu, filmler/müşteriler/koltuklar/rezervasyonlar çalışıyor mu?
- Veritabanı kullanıcısı yeni DB oluşturmaya yetkili mi?
- Uygulama hata verirse log oluşuyor mu?
- GitHub dağıtımına DevExpress lisansı izin veriyor mu?

### Önemli sınırlar
- Bu paketi burada Windows/DevExpress üzerinde derlemedim; geliştiricinin yerel ortamında test edilmelidir.
- Yeni bilgisayarda SQL Express otomatik **kurulmaz**; installer/önkoşul yönetimi ayrı iştir.
- Her bilgisayar farklı `localhost` SQL sunucusuna bağlanır; paylaşımlı veri için merkezi veritabanı gerekir.
- EF6 `CreateDatabaseIfNotExists` ilk oluşturmayı destekler, mevcut veritabanında şema değişikliklerini yönetmez; bunun için EF migrations gerekir.
- Üretim dağıtımında SQL yetkilerini minimuma indirin, SQL sunucusunu internete açmayın.

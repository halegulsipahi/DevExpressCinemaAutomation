using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DevExpressCinemaAutomation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += (sender, args) => ReportError(args.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                var error = args.ExceptionObject as Exception;
                if (error != null) ReportError(error);
            };
            try
            {
                Application.Run(new FrmMain());
            }
            catch (Exception ex)
            {
                ReportError(ex);
            }
        }

        private static void ReportError(Exception error)
        {
            string location = "";
            try
            {
                string folder = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "CinemaAutomation", "Logs");
                Directory.CreateDirectory(folder);
                location = Path.Combine(folder, "errors.log");
                File.AppendAllText(location,
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine
                    + error + Environment.NewLine + Environment.NewLine,
                    Encoding.UTF8);
            }
            catch { /* Logging must not crash the error handler. */ }

            try
            {
                MessageBox.Show(
                    "Uygulamada bir hata oluştu. Bağlantı ayarlarını kontrol edin." +
                    (location.Length > 0 ? "\nAyrıntılar: " + location : "") +
                    "\n\n" + error.Message,
                    "Cinema Automation - Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { }
        }
    }
}

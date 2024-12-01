using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Uygulaması
{
    public partial class MainPage : Form
    {
        private readonly AppDbContext _context;

        public MainPage(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReportPage reportPage = Program.ServiceProvider.GetRequiredService<ReportPage>();

            reportPage.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = Program.ServiceProvider.GetRequiredService<LoginPage>();

            loginPage.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            using (var context = _context)
            {
                // PostgreSQL bağlantı bilgilerini alın
                var database = context.Database.GetDbConnection().Database;
                var host = "localhost"; // Sunucu adı
                var port = "5432";      // PostgreSQL varsayılan portu
                var username = "postgres"; // Kullanıcı adı
                var password = "Password1"; // Şifre

                // Belgelerim klasörüne yedek dosyası kaydedilecek
                var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var backupFileName = "database_backup.backup";
                var backupFilePath = Path.Combine(documentsPath, backupFileName);

                var pgDumpPath = @"C:\Program Files\PostgreSQL\15\bin\pg_dump";
                // pg_dump komutu oluşturuluyor
                var arguments = $"-h {host} -p {port} -U {username} -F c -b -v -f \"{backupFilePath}\" {database}";

                // PostgreSQL şifresini ortam değişkenine ayarla
                Environment.SetEnvironmentVariable("PGPASSWORD", password);

                try
                {
                    // pg_dump işlemini başlat
                    var processStartInfo = new ProcessStartInfo
                    {
                        FileName = pgDumpPath, // pg_dump komutunu çalıştır
                        Arguments = arguments,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (var process = Process.Start(processStartInfo))
                    {
                        // Çıktı ve hata mesajlarını oku
                        var output = process.StandardOutput.ReadToEnd();
                        var error = process.StandardError.ReadToEnd();

                        process.WaitForExit();

                        if (process.ExitCode == 0)
                        {
                            Console.WriteLine($"Veritabanı yedeği başarıyla alındı: {backupFilePath}");
                        }
                        else
                        {
                            Console.WriteLine($"Hata oluştu: {error}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Yedekleme sırasında bir hata oluştu: {ex.Message}");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReportPage reportPage = Program.ServiceProvider.GetRequiredService<ReportPage>();

            reportPage.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

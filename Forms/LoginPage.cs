using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Stok_Uygulaması.Class;
using Stok_Uygulaması.Enums;
using Stok_Uygulaması.Model;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace Stok_Uygulaması
{
    public partial class LoginPage : Form
    {
        readonly GenericRepository<Users> _userGeneric;
        public User User { get; set; }
        public LoginPage(GenericRepository<Users> userGeneric)
        {
            _userGeneric = userGeneric;
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }



        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Salt oluşturma
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (RNGCryptoServiceProvider rng = new())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        // Şifreyi salt ile hash'leme
        public static string HashPasswordWithSalt(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Şifre ve salt'ı birleştir
                string saltedPassword = password + salt;
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(saltedPassword);

                // Hash hesapla
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve parola null kontrolü yapıyoruz
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                label2.Text = "Kullanıcı adı ve parola zorunludur";
                return;
            }

            // Kullanıcı veri tabanında bulunuyormu ona bakıyoruz
            if (!_userGeneric.Any(x => x.UserName.Equals(textBox1.Text)))
            {
                label2.Text = $"{textBox1.Text} adında bir kullanıcı bulunmuyor";
                return;
            }

            if (!_userGeneric.Any(x => x.UserName.Equals(textBox1.Text) && x.Status == 0))
            {
                label2.Text = $"Kullanıcının pasif durumdadır";
                return;
            }

            string password = textBox2.Text;

            var userSalt = _userGeneric.Where(x => x.UserName.Equals(textBox1.Text)).Select(x => x.Salt).First();

            string hashedPassword = HashPasswordWithSalt(password, userSalt);

            if (!_userGeneric.Any(x => x.PasswordHash.Equals(hashedPassword)))
            {
                label2.Text = $"Kullanıcının parolası hatalıdır";
                return;
            }
            else
            {
                

                if (textBox1.Text == "admin")
                {
                    User.UserName = textBox1.Text;
                    //eğer admin şifresi 1 ise güncelleme sayfasına gönderiyoruz

                    if (password == "1" )
                    {

                        AdminPage adminPage = Program.ServiceProvider.GetRequiredService<AdminPage>();

                        adminPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        AdminAnasayfa adminAnasayfa = Program.ServiceProvider.GetRequiredService<AdminAnasayfa>();
                        adminAnasayfa.Show();
                        this.Hide();
                    }

                }
                else
                {
                    oldMainPage mainPage = Program.ServiceProvider.GetRequiredService<oldMainPage>();

                    mainPage.Show();
                    this.Hide();
                }
            }
        }
    }
}

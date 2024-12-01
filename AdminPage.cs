using Microsoft.Extensions.DependencyInjection;
using Stok_Uygulaması.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Uygulaması
{
    public partial class AdminPage : Form
    {

        readonly GenericRepository<Users> _userGeneric;
        readonly GenericRepository<Product> _productGeneric;
        readonly UnitOfWork _unitOfWork;

        public AdminPage(GenericRepository<Users> userGeneric, GenericRepository<Product> productGeneric, UnitOfWork unitOfWork)
        {
            _userGeneric = userGeneric;
            _productGeneric = productGeneric;


            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string şifre1 = textBox3.Text;
            string şifre2 = textBox4.Text;

            // eski şifre ve yeni şifreler boş olmama durumu
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(şifre1) || string.IsNullOrEmpty(şifre2))
            {
                pictureBox1.Visible = true;
                label5.Text = "Eksik veya hatalı bilgi girdiniz";
                return;
            }
            else
            {
                label5.Text = "";
            }



            //yeni şifre uyuşması

            if (şifre1 != şifre2)
            {
                pictureBox1.Visible = true;
                label5.Text = "Yeni parolalar eşleşmiyor";
                return;
            }
            else
            {
                label5.Text = "";
            }

            //eski şifre doğru olup olmaması

            string oldpassword = textBox2.Text;
            var usersalt = _userGeneric.Where(x => x.UserName.Equals(textBox1.Text)).Select(x => x.Salt).First();
            var hashed = LoginPage.HashPasswordWithSalt(oldpassword, usersalt);

            if (!_userGeneric.Any(x => x.PasswordHash == hashed))
            {
                pictureBox1.Visible = true;
                label5.Text = "eski şifreniz hatalıdır";
                return;
            }
            else
            {
                label5.Text = "";

            }

            //şifre formata uyuyor mu kontrolü

            if (!ValidatePassword(şifre2))
            {
                pictureBox1.Visible = true;
                label5.Text = "Parolanız Formatı Uygun Değildir";
                return;
            }
            else { label5.Text = ""; }

            //Güncelleme İşlemi

            var salt = LoginPage.GenerateSalt();
            var hash = LoginPage.HashPasswordWithSalt(şifre2, salt);
            var admin = _userGeneric.Where(x => x.UserName == textBox1.Text).First();
            admin.PasswordHash = hash;
            admin.Salt = salt;
            admin.UpdatedDate = DateTime.UtcNow;
            _userGeneric.Update(admin);
            _unitOfWork.Commit();

            //AdminAnasayfaya gönderme

            AdminAnasayfa adminAnasayfa = Program.ServiceProvider.GetRequiredService<AdminAnasayfa>();
            adminAnasayfa.Show();
            this.Hide();







        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }
        public static bool ValidatePassword(string password)
        {
            // Şifre koşullarını kontrol eden regex:
            var regex = new Regex(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[^\w\s]).{6,}$");
            return regex.IsMatch(password);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }
    }
}

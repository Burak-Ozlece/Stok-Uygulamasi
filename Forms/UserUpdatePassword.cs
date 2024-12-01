using Stok_Uygulaması.Class;
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

namespace Stok_Uygulaması.Forms
{
    public partial class UserUpdatePassword : Form
    {
        public User User { get; set; }
        readonly GenericRepository<Users> _userGeneric;
        readonly UnitOfWork _unitOfWork;


        public UserUpdatePassword(GenericRepository<Users> userGeneric, UnitOfWork unitOfWork)
        {
            InitializeComponent();
            _userGeneric = userGeneric;
            _unitOfWork = unitOfWork;
        }

        private void UserUpdatePassword_Load(object sender, EventArgs e)
        {
            textBox1.Text = User.UserName;

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

            if (!SharedClass.ValidatePassword(şifre2))
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
             MessageBox.Show($"Başarılı bir şekilde güncellenmiştir şifre", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}

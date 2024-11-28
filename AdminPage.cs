using Stok_Uygulaması.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Uygulaması
{
    public partial class AdminPage : Form
    {

        readonly GenericRepository<Users> _userGeneric;
        readonly GenericRepository<Product> _productGeneric;

        public AdminPage(GenericRepository<Users> userGeneric, GenericRepository<Product> productGeneric)
        {
            _userGeneric = userGeneric;
            _productGeneric = productGeneric;


            InitializeComponent();  
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // eski şifre ve yeni şifreler boş olmama durumu
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                label5.Text = "Eksik veya hatalı bilgi girdiniz";
            }
            else
            {
                label5.Text = "";
            }

            string oldpassword = textBox2.Text;
            var usersalt = _userGeneric.Where(x => x.UserName.Equals(textBox1.Text)).Select(x => x.Salt).First();
            var hashed = LoginPage.HashPasswordWithSalt(oldpassword, usersalt);

            if (!_userGeneric.Any(x => x.PasswordHash == hashed))
            {
                label5.Text = "eski şifreniz hatalıdır";
            }
            else
            {
                label5.Text = "";
            }

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }
    }
}

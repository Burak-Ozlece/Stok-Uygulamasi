using Stok_Uygulaması.Forms;
using Stok_Uygulaması.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Uygulaması
{
    public partial class MainPage : Form
    {
        readonly GenericRepository<ProductStockStatus> _ProductStockStatus;
        readonly GenericRepository<Users> _userGeneric;

        public MainPage(GenericRepository<ProductStockStatus> productStockStatus, GenericRepository<Users> userGeneric)
        {
            //this.WindowState = FormWindowState.Maximized;  // Formu tam ekran yap
            //this.TopMost = true;  // Uygulama her zaman ön planda
            InitializeComponent();
            _ProductStockStatus = productStockStatus;
            _userGeneric = userGeneric;

        }

        private void Depo_Load(object sender, EventArgs e)
        {

            //if (this.WindowState != FormWindowState.Maximized)
            //{
            //    this.FormBorderStyle = FormBorderStyle.FixedDialog; // Sabit boyut
            //    //this.Size = new Size(1024, 768); // Sabit boyut belirlenir
            //    this.Size = new Size(1312, 631); // Sabit boyut belirlenir
            //}
            //else
            //{
            //    this.FormBorderStyle = FormBorderStyle.None; // Tam ekran modunda kenar çubuğunu kaldırır
            //}



            ProductStockStatus stok = new ProductStockStatus();

            var ürünlisteleme = _ProductStockStatus.GetAll();

        }

        // Depo butonuna click olayı yapıldığında çalışacak fonksiyon
        private void depobuton_Click(object sender, EventArgs e)
        {
            label1.Text = "DEPO";

            // Alt formu oluştur
            Depo childForm = new()
            {
                TopLevel = false, 
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            // Alt formu panel içine ekle
            mainPanel.Controls.Clear(); // Önceki formları temizle
            mainPanel.Controls.Add(childForm);
            childForm.Show();

        }

        // Çıkış butonuna click olayı yapıldığında çalışacak fonksiyon
        private void cikisbutton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Uygulamayı kapatmak istediğinize eminmisiniz", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            // Çıkışa onay verirse uygulamayı kapatıyoruz
            if (result == DialogResult.OK)
                Application.Exit();
        }


    }
}

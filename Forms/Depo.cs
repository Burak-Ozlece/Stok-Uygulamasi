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
    public partial class Depo : Form
    {
        readonly GenericRepository<ProductStockStatus> _ProductStockStatus;
        readonly GenericRepository<Users> _userGeneric;

        public Depo(GenericRepository<ProductStockStatus> productStockStatus, GenericRepository<Users> userGeneric)
        {
            //this.WindowState = FormWindowState.Maximized;  // Formu tam ekran yap
            //this.TopMost = true;  // Uygulama her zaman ön planda
            InitializeComponent();
            _ProductStockStatus = productStockStatus;
            _userGeneric = userGeneric;

        }

        private void Depo_Load(object sender, EventArgs e)
        {

            if (this.WindowState != FormWindowState.Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.FixedDialog; // Sabit boyut
                this.Size = new Size(1024, 768); // Sabit boyut belirlenir
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None; // Tam ekran modunda kenar çubuğunu kaldırır
            }



            ProductStockStatus stok = new ProductStockStatus();

            var ürünlisteleme = _ProductStockStatus.GetAll();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "DEPO";

            // Alt formu oluştur
            Deneme childForm = new Deneme();

            // Ayarlar: Panel içine formu yerleştirme
            childForm.TopLevel = false; // Üst seviye bir form olmasın
            childForm.FormBorderStyle = FormBorderStyle.None; // Kenarlık olmadan
            childForm.Dock = DockStyle.Fill; // Tamamen Panel'i doldursun

            // Alt formu panel içine ekle
            panel2.Controls.Clear(); // Önceki formları temizle
            panel2.Controls.Add(childForm);
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Uygulamayı kapatmak istediğinize eminmisiniz", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK) 
                Application.Exit();
        }
    }
}

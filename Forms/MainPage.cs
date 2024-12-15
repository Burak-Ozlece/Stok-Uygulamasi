using Microsoft.Extensions.DependencyInjection;
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




            ProductStockStatus stok = new ProductStockStatus();

            var ürünlisteleme = _ProductStockStatus.GetAll();

        }

        // Depo butonuna click olayı yapıldığında çalışacak fonksiyon
        private void depobuton_Click(object sender, EventArgs e)
        {
            label1.Text = "DEPO";
            Depo childForm = Program.ServiceProvider.GetRequiredService<Depo>();

            // Form özelliklerini doğru bir şekilde ayarla
            childForm.TopLevel = false; // Üst düzey form olmadığını belirt
            childForm.FormBorderStyle = FormBorderStyle.None; // Kenarlık kaldır
            childForm.Dock = DockStyle.Fill; // Paneli doldur

            // Alt formu panel içine ekle
            mainPanel.Controls.Clear(); // Önceki formları temizle
            mainPanel.Controls.Add(childForm); // Formu panel içine ekle
            childForm.Show(); // Formu göster

        }

        // Çıkış butonuna click olayı yapıldığında çalışacak fonksiyon
        private void cikisbutton_Click(object sender, EventArgs e)
        {
            cikisbutton.BackColor = Color.FromArgb(62, 50, 50);

            button1.BackColor = Color.FromArgb(80, 60, 60);
            button2.BackColor = Color.FromArgb(80, 60, 60);
            button4.BackColor = Color.FromArgb(80, 60, 60);
            button5.BackColor = Color.FromArgb(80, 60, 60);
            depobuton.BackColor = Color.FromArgb(80, 60, 60);
            button6.BackColor = Color.FromArgb(80, 60, 60);

            var result = MessageBox.Show($"Uygulamayı kapatmak istediğinize eminmisiniz", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            // Çıkışa onay verirse uygulamayı kapatıyoruz
            if (result == DialogResult.OK)
                Application.Exit();

        }

        private void depobuton_MouseClick(object sender, MouseEventArgs e)
        {
            //Depo Butonu Renk Düzenleme
            depobuton.BackColor = Color.FromArgb(62, 50, 50);

            button1.BackColor = Color.FromArgb(80, 60, 60);
            button2.BackColor = Color.FromArgb(80, 60, 60);
            button4.BackColor = Color.FromArgb(80, 60, 60);
            button5.BackColor = Color.FromArgb(80, 60, 60);
            button6.BackColor = Color.FromArgb(80, 60, 60);
            cikisbutton.BackColor = Color.FromArgb(80, 60, 60);

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            //ürünler Butonu Renk Düzenleme

            button2.BackColor = Color.FromArgb(62, 50, 50);

            button1.BackColor = Color.FromArgb(80, 60, 60);
            depobuton.BackColor = Color.FromArgb(80, 60, 60);
            button4.BackColor = Color.FromArgb(80, 60, 60);
            button5.BackColor = Color.FromArgb(80, 60, 60);
            button6.BackColor = Color.FromArgb(80, 60, 60);
            cikisbutton.BackColor = Color.FromArgb(80, 60, 60);
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            // Yedekleme Butonu renk düzenleme
            button4.BackColor = Color.FromArgb(62, 50, 50);

            button1.BackColor = Color.FromArgb(80, 60, 60);
            depobuton.BackColor = Color.FromArgb(80, 60, 60);
            button2.BackColor = Color.FromArgb(80, 60, 60);
            button5.BackColor = Color.FromArgb(80, 60, 60);
            button6.BackColor = Color.FromArgb(80, 60, 60);
            cikisbutton.BackColor = Color.FromArgb(80, 60, 60);

        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            // Üyeler butonu renk düzeni
            button5.BackColor = Color.FromArgb(62, 50, 50);

            button1.BackColor = Color.FromArgb(80, 60, 60);
            depobuton.BackColor = Color.FromArgb(80, 60, 60);
            button2.BackColor = Color.FromArgb(80, 60, 60);
            button4.BackColor = Color.FromArgb(80, 60, 60);
            button6.BackColor = Color.FromArgb(80, 60, 60);
            cikisbutton.BackColor = Color.FromArgb(80, 60, 60);

        }



        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            // Ayarlar butonu renk düzeni 
            button6.BackColor = Color.FromArgb(62, 50, 50);

            button1.BackColor = Color.FromArgb(80, 60, 60);
            button2.BackColor = Color.FromArgb(80, 60, 60);
            button4.BackColor = Color.FromArgb(80, 60, 60);
            button5.BackColor = Color.FromArgb(80, 60, 60);
            depobuton.BackColor = Color.FromArgb(80, 60, 60);
            cikisbutton.BackColor = Color.FromArgb(80, 60, 60);

        }



        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //raporlama butonu renk düzeni
            button1.BackColor = Color.FromArgb(62, 50, 50);

            button6.BackColor = Color.FromArgb(80, 60, 60);
            button2.BackColor = Color.FromArgb(80, 60, 60);
            button4.BackColor = Color.FromArgb(80, 60, 60);
            button5.BackColor = Color.FromArgb(80, 60, 60);
            depobuton.BackColor = Color.FromArgb(80, 60, 60);
            cikisbutton.BackColor = Color.FromArgb(80, 60, 60);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Alt formu oluştur
            Ürünler childForm = new()
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
    }
}

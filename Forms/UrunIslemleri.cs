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

namespace Stok_Uygulaması.Forms
{
    public partial class UrunIslemleri : Form
    {
        readonly GenericRepository<Product> _productGeneric;

        public UrunIslemleri(GenericRepository<Product> productGeneric)
        {
            _productGeneric = productGeneric;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var urunAdi = textBox1.Text;

            if (string.IsNullOrEmpty(urunAdi))
            {
                MessageBox.Show("Ürün adı yazınız", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _productGeneric.Where(x => x.Name.Contains(urunAdi)).Select(x => new { x.Id, x.Name, x.Barkod }).ToList();

            if (result.Any())
            {
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("Ürün bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null; // Önceki sonuçları temizler
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var urunAdi = textBox1.Text;
            var urunResmi = pictureBox1.Image;

            if (string.IsNullOrEmpty(urunAdi))
            {
                MessageBox.Show("Ürün adı yazınız", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var urunVarmi = _productGeneric.Any(x => x.Name.Equals(urunAdi));

            if (urunVarmi)
            {
                MessageBox.Show("Ürün bulunuyor", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Product product = new()
            //{
            //    Name = urunAdi,
            //    Image = 
            //}

            //_productGeneric.AddAsync()
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UrunIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}

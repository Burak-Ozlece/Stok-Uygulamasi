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
            panel1.Dock = DockStyle.Top;
            


            ProductStockStatus stok = new ProductStockStatus();

            var ürünlisteleme = _ProductStockStatus.GetAll();
            dataGridView1.DataSource = ürünlisteleme;
        }
    }
}

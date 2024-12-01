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
    public partial class ReportPage : Form
    {
        public ReportPage()
        {
            this.WindowState = FormWindowState.Maximized;  // Formu tam ekran yap
            this.TopMost = true;  // Uygulama her zaman ön planda
            InitializeComponent();
        }

        private void ReportPage_Load(object sender, EventArgs e)
        {

        }
    }
}

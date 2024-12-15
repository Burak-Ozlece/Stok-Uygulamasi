using Stok_Uygulaması.Dtos;
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
    public partial class Depo : Form
    {
        readonly GenericRepository<Product> _productGeneric;
        readonly GenericRepository<ProductMovement> _productMovementGeneric;

        public Depo(GenericRepository<Product> productGeneric, GenericRepository<ProductMovement> productMovementGeneric)
        {
            _productGeneric = productGeneric;
            _productMovementGeneric = productMovementGeneric;
            InitializeComponent();
        }

        private void urunAraButon_Click(object sender, EventArgs e)
        {
            if (barkodTextBox.Text.StartsWith("#"))
            {
                barkodTextBox.Text = barkodTextBox.Text.Replace("#", "");
                var product = _productGeneric.Where(x=>x.Barkod.Equals(barkodTextBox.Text)).Select(x=>new { x.Id, x.Name, x.Category, x.Image }).FirstOrDefault();

                if (product == null)
                {
                    MessageBox.Show("Ürün bulunamadı", null, MessageBoxButtons.OK);
                    return;
                }

                string category = null;

                switch (product.Category)
                {
                    case Enums.CategoryEnum.Elektronik:
                        category = "Elektronik";
                        break;
                    default:
                        break;
                }

                ProductDto productDto = new()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Category = category
                };
                depodakiUrunlerDataGrid.Columns.Add("Id", "ID");
                depodakiUrunlerDataGrid.Columns.Add("Name", "Name");
                depodakiUrunlerDataGrid.Columns.Add("Category", "Category");

                depodakiUrunlerDataGrid.Rows.Add(productDto.Id, productDto.Name, productDto.Category);
                return;
            }
            else
            {
                var product = _productGeneric.Where(x => x.Name.Contains(barkodTextBox.Text.ToUpper())).Select(x => new { x.Id, x.Name, x.Category, x.Image }).ToList();

                if(product.Count == 0)
                {
                    MessageBox.Show("Ürün bulunamadı", null, MessageBoxButtons.OK);
                    return;
                }
                depodakiUrunlerDataGrid.Columns.Add("Id", "ID");
                depodakiUrunlerDataGrid.Columns.Add("Name", "Name");
                depodakiUrunlerDataGrid.Columns.Add("Category", "Category");
                depodakiUrunlerDataGrid.Rows.Clear();
                foreach (var item in product)
                {
                    string category = null;

                    switch (item.Category)
                    {
                        case Enums.CategoryEnum.Elektronik:
                            category = "Elektronik";
                            break;
                        default:
                            break;
                    }
                    ProductDto productDto = new()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Category = category
                    };
                    depodakiUrunlerDataGrid.Rows.Add(productDto.Id, productDto.Name, productDto.Category);
                }
            }

        }

        private void Depo_Load(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            // DataGridView kontrolünde veri var mı kontrol et
            bool hasData = secilenUrunlerDataGrid.Rows.Count > 0;

            // Butonların Enabled özelliğini güncelle
            teslimEtButon.Enabled = hasData;
            teslimAlButon.Enabled = hasData;
        }
    }
}

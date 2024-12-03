using Stok_Uygulaması.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Uygulaması.Model
{
    public class ProductStockStatus
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public string Unit { get; set; }
        public int Amount { get; set; }
        public StatusEnum Status { get; set; }
    }
}

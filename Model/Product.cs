using Stok_Uygulaması.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Uygulaması.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Barkod { get; set; }
        public CategoryEnum Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public StatusEnum Status { get; set; }
    }
}

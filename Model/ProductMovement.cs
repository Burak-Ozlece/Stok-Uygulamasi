using Stok_Uygulaması.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Uygulaması.Model
{
    public class ProductMovement
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Member ReceivingMember { get; set; }
        public Member SubmittingMember { get; set; }
        public Users WarehouseManager { get; set; }
        public DateTime ReceivingDate { get; set; }
        public DateTime SubmittingDate { get; set; }
    }
}

using Stok_Uygulaması.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Uygulaması.Model
{
    public class Member
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; }
        public StatusEnum Status { get; set; }
    }
}

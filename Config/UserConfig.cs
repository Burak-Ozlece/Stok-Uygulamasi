using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stok_Uygulaması.Enums;
using Stok_Uygulaması.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Uygulaması.Config
{
    public class UserConfig : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasData(
                new Users()
                {
                    Id = 1,
                    UserName = "admin",
                    PasswordHash = "3Hy8zbqdUwaHBYNw5Pk8h+PP42YarBP1N3mBoXBbgrc=",
                    Salt = "I2Fmswvjufks8K5YK0+/5g==",
                    CreatedDate = DateTime.UtcNow,
                    Status = StatusEnum.Aktif
                });
        }
    }
}

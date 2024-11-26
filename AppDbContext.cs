using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore; // Doğru Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Stok_Uygulaması.Model;

namespace Stok_Uygulaması
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        // Diğer DbSet tanımlamalarını buraya ekleyebilirsiniz.
        protected override void OnModelCreating(ModelBuilder modelBuilder) // EF Core'da ModelBuilder kullanılır
        {
            base.OnModelCreating(modelBuilder);
        }

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
        {
            public AppDbContext CreateDbContext(string[] args)
            {
                // appsettings.json'dan bağlantı dizesini al
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                var connectionString = configuration.GetConnectionString("postgre");

                optionsBuilder.UseNpgsql(connectionString);

                return new AppDbContext(optionsBuilder.Options);
            }
        }
    }
}

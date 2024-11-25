using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stok_Uygulaması.Model;

namespace Stok_Uygulaması
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Configuration Setup
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Service Collection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection, configuration);

            // Create a service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var userRepository = serviceProvider.GetRequiredService<GenericRepository<UserApp>>();
            var productRepository = serviceProvider.GetRequiredService<GenericRepository<Product>>();

            // Pass repositories to Form1
            Application.Run(new Form1(userRepository, productRepository));
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            // Get the connection string from appsettings.json
            string connection = configuration.GetConnectionString("dbBrowser");

            // Add DbContext with Npgsql (PostgreSQL)
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite(connection); // SQLite için UseSqlite kullanılır
            });

            // Register GenericRepository<T> as scoped
            services.AddScoped(typeof(GenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
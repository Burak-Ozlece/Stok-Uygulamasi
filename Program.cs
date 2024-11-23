using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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

            // Get AppDbContext from DI container
            var dbContext = serviceProvider.GetRequiredService<AppDbContext>();

            // Pass AppDbContext to Form1
            Application.Run(new Form1(dbContext));
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            // Get the connection string from appsettings.json
            string connection = configuration.GetConnectionString("postgre");

            // Add DbContext with Npgsql (PostgreSQL)
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(connection, sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly("Stok Uygulaması"); // Update with your assembly name
                });
            });

            // Register other services if needed
        }
    }
}
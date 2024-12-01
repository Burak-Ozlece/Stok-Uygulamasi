using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Stok_Uygulaması.Model;

namespace Stok_Uygulaması
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            // Windows Forms uygulama yapılandırması
            ApplicationConfiguration.Initialize();

            // Konfigürasyon dosyasını yükle
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Servis koleksiyonu oluştur ve bağımlılıkları kaydet
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection, configuration);

            // ServiceProvider oluştur
            ServiceProvider = serviceCollection.BuildServiceProvider();

            // Giriş sayfasını başlat
            var loginPage = ServiceProvider.GetRequiredService<LoginPage>();
            var mainPage = ServiceProvider.GetRequiredService<MainPage>();
            Application.Run(mainPage);
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            // Veritabanı bağlantı dizesini al
            string connectionString = configuration.GetConnectionString("postgre");

            // DbContext'i kaydet
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            // Generic repository'leri kaydet
            services.AddScoped(typeof(GenericRepository<>), typeof(GenericRepository<>));

            // Formları bağımlılıklarıyla birlikte kaydet
            services.AddTransient<LoginPage>();
            services.AddTransient<AdminPage>();
            services.AddTransient<MainPage>();
        }
    }
}
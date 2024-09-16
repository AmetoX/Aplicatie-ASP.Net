using AplicatieASP.Components.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AplicatieASP.Components.DataBase
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(_configuration.GetConnectionString("DefaultConnection"),
                new MySqlServerVersion(new Version(8, 0, 36)))); // Specify your MySQL version

            services.AddTransient<MySqlUserService>(); // Register the MySqlUserService
            services.AddControllersWithViews(); // For MVC/Web
        }
    }
}

using WebAppAsp.Components;
using WebAppAsp.Components.DataBase;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace WebAppAsp
{
	//Install-Package MySql.Data.EntityFrameworkCore
	//Install-Package Pomelo.EntityFrameworkCore.MySql
	//Install-Package Microsoft.EntityFrameworkCore.Tools
	//Add-Migration InitialCreate
	//Update-Database
	public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Add DbContext to the services
            builder.Services.AddDbContext<BookShelfContext>(options =>
            options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
            ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")),
                mysqlOptions =>
                    mysqlOptions.SchemaBehavior(MySqlSchemaBehavior.Ignore) // Ignore schema
            ));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}

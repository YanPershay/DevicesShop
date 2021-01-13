using DevicesShop.Data;
using DevicesShop.Data.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevicesShop.Data.Repository;
using DevicesShop.Data.Models;

namespace GadgetsShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<DeviceContext>(options =>
                options.UseSqlServer(connection));

            services.AddTransient<IAllDevices, DeviceRepository>();
            services.AddTransient<IDeviceCategory, CategoryRepository>();
            services.AddTransient<IAllOrders, OrderRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetShopCart(sp));

            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DeviceContext db)
        {
            app.UseDeveloperExceptionPage();

            db.Database.EnsureCreated();

            app.UseStatusCodePages();

            app.UseStaticFiles();

            app.UseSession();

            //app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "categories",
                    template: "Devices/{action}/{category?}",
                    defaults: new { Controller = "Devices", Action = "ProductsList" });
            });

            //using (var scope = app.ApplicationServices.CreateScope())
            //{
            //    DeviceContext context = scope.ServiceProvider.GetRequiredService<DeviceContext>();
            //    DbObjects.Init(context);
            //}
        }
    }
}

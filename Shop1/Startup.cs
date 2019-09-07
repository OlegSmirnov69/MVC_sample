using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shop1.Data.Interfaces;
using Shop1.Data.Mocks;
using Shop1.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Shop1.Data.Repository;
using Shop1.Data.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

namespace Shop1
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddDbContext<UserContext>(options => options.UseSqlServer(_confString.GetConnectionString("UserConnection")));
            services.AddTransient<IItems, ItemRepository>();
            services.AddTransient<ICategories, CategoryRepository>();
            services.AddTransient<IAllOrders, OrdersRepository>();
            //services.AddTransient<IComments, CommentRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => Cart.GetCart(sp));
            //------------------ OLD AUTH REALIZATION
            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(options => //CookieAuthenticationOptions
            //    {
            //        options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
            //    });

            //----------------- NEW AUTH REALIZATION
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<UserContext>();


            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
            //old realizations of interfaces
            /*
            services.AddTransient<IItems, MockItem>();
            services.AddTransient<ICategories, MockCategory>();*/

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();
            app.UseAuthentication(); //     auth added

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "Item/ShowList/{category?}", defaults: new { Controller= "Item", action= "ShowList" });
            });

            //DBObjects.Init(app); //ініціалізує обєкти БД при старті проги   
            // creating of okruzenie(scope)
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                //UserContext comm_content = scope.ServiceProvider.GetRequiredService<UserContext>();
                DBObjects.Init(content);
                //DBObjects.InitComments(comm_content);
            }

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.Run(async (context) =>
            //    {
            //        await context.Response.WriteAsync("indev");
            //    });
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});


        }
    }
}

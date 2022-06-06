using App.Models;
using AppMVC.Net.ExtendMethods;
using AppMVC.Net.Models;
using AppMVC.Net.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AppMVC.Net
{
    public class Startup
    {
        public static string ContentRootPath { get; set; }
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            ContentRootPath = env.ContentRootPath;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AppDbContext>(options => {
                string connectString = Configuration.GetConnectionString("AppMvcConnectionString");
                options.UseSqlServer(connectString);
            });

            services.AddControllersWithViews();
            services.AddRazorPages();
            // services.AddTransient(typeof(ILogger<>), typeof(Logger<>));

            services.Configure<RazorViewEngineOptions>(options =>
            {
                // /View/Controller/Action.html
                // /MyView/Controler/Action.html

                // {0} -> tên Action
                // {1} -> tên Controller
                // {2} -> tên Area
                
                options.ViewLocationFormats.Add("/MyView/{1}/{0}" + RazorViewEngine.ViewExtension);
            });

            //services.AddSingleton<ProductService>();
            //services.AddSingleton<ProductService, ProductService>();
            //services.AddSingleton(typeof(ProductService));
            services.AddSingleton(typeof(ProductService), typeof(ProductService));
            services.AddSingleton<PlanetService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.AddStatusCodePage();

            app.UseRouting();
            
            app.UseAuthentication(); // xác định danh tính
            app.UseAuthorization(); // xác định quyền truy cập

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/sayFudge", async context =>
                {
                    await context.Response.WriteAsync($"Hello con vk bi hack lan nua {DateTime.Now}");
                });


                //endpoints.MapControllers
                //endpoints.MapControllerRoute
                //endpoints.MapDefaultControllerRoute
                //endpoints.MapAreaControllerRoute


                endpoints.MapControllers();

                endpoints.MapControllerRoute(
                    name:"first",
                    pattern:"{url:regex(^((xemsanpham)|(ViewProduct))$)}/{id:range(2,4)}",
                    defaults: new
                    {
                        controller = "First",
                        action = "ViewProduct"
                    }
                    //constraints: new
                    //{
                    //    url = "xemsanpham",
                    //    id = new RangeRouteConstraint(2,4)
                    //}
                    );

                endpoints.MapAreaControllerRoute(
                    name: "product",
                    pattern: "/{controller=Home}/{action=Index}/{id?}",
                    areaName: "ProductManage" 
                    );

                // URl = start-here
                // controller =>
                // action =>
                // area =>
                // Controller không có area
                endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"/{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapRazorPages();   
            });
        }
    }
}

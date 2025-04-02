using EcommerceWebAppAngularjs.Data;
using EcommerceWebAppAngularjs.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EcommerceWebAppAngularjs
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configure cookie policy
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Set up database context
            var connectionString = Configuration.GetConnectionString("DevConnection");

            // Ensure the connection string is not null
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("connectionString", "Connection string is not provided.");
            }

            // Use SQL Server with the connection string
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString)
            );

            // Add MVC services
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2); // Ensure compatibility for ASP.NET Core 2.2

            services.AddIdentity<Customer, ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)  // Use IHostingEnvironment for ASP.NET Core 2.2
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();  // For ASP.NET Core 2.2, use UseMvc() instead of UseRouting()

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "Admin",
                    template: "{area:exists}/{controller=Products}/{action=Index}/{id?}");
            });


       
        }
    }
}

using System;
using EcommerceWebAppAngularjs.Data;
using EcommerceWebAppAngularjs.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EcommerceWebAppAngularjs.Areas.Identity.IdentityHostingStartup))]
namespace EcommerceWebAppAngularjs.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EcommerceWebAppAngularjsContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EcommerceWebAppAngularjsContextConnection")));

                services.AddDefaultIdentity<Customer>()
                    .AddEntityFrameworkStores<EcommerceWebAppAngularjsContext>();
            });
        }
    }
}
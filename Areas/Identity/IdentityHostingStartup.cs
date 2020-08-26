using System;
using Latin_Dance.Areas.Identity.Data;
using Latin_Dance.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Latin_Dance.Areas.Identity.IdentityHostingStartup))]
namespace Latin_Dance.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Latin_DanceDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Latin_DanceDbContextConnection")));

                services.AddDefaultIdentity<Latin_DanceUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Latin_DanceDbContext>();
            });
        }
    }
}
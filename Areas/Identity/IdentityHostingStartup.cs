using System;
using Carenjot_core.Areas.Identity.Data;
using Carenjot_core.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Carenjot_core.Areas.Identity.IdentityHostingStartup))]
namespace Carenjot_core.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Carenjot_coreContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Carenjot_coreContextConnection")));

                services.AddDefaultIdentity<Carenjot_coreUser>()
                    .AddEntityFrameworkStores<Carenjot_coreContext>();
            });
        }
    }
}
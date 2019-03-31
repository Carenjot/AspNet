using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carenjot_core.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Carenjot_core.Models
{
    public class Carenjot_coreContext : IdentityDbContext<Carenjot_coreUser>
    {
        public Carenjot_coreContext(DbContextOptions<Carenjot_coreContext> options)
            : base(options)
        {

        }

        public DbSet<Task> Task { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}

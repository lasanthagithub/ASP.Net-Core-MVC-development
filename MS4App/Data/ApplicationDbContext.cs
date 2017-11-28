using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MS4App.Models;
using MS4App.Models.CalculationViewModels;

namespace MS4App.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Let entity framework know, these classes needs to be converted to db tables
        public DbSet<CnItems> CnItemsMain { get; set; }
        public DbSet<CnItemsSelect1> CnItemsSelection1 { get; set; }
        public DbSet<CnItemsSelect2> CnItemsSelection2 { get; set; }
        public DbSet<CnItemsSelect3> CnItemsSelection3 { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // To make primary key auto generate
            //modelBuilder.Entity<CnItemsSelect1>()
            //.Property(f => f.S1Id)
            //.ValueGeneratedOnAddOrUpdate();

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}

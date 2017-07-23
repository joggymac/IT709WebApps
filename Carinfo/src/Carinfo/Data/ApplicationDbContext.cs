using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Carinfo.Models;
using Car_Database.Models;

namespace Carinfo.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<CarBrand> CarBrand { get; set; }

        public DbSet<CarModel> CarModel { get; set; }

        public DbSet<Cylinder> Cylinder { get; set; }

        public DbSet<DriveType> DriveType { get; set; }

        public DbSet<FuelType> FuelType { get; set; }

        public DbSet<GearBox> GearBox { get; set; }

        public DbSet<Subaru> Subaru { get; set; }
    }
}

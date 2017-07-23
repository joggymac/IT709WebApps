using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication3.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Car_Database.Models.CarBrand> CarBrands { get; set; }

        public System.Data.Entity.DbSet<Car_Database.Models.CarModel> CarModels { get; set; }

        public System.Data.Entity.DbSet<Car_Database.Models.Cylinder> Cylinders { get; set; }

        public System.Data.Entity.DbSet<Car_Database.Models.DriveType> DriveTypes { get; set; }

        public System.Data.Entity.DbSet<Car_Database.Models.FuelType> FuelTypes { get; set; }

        public System.Data.Entity.DbSet<Car_Database.Models.GearBox> GearBoxes { get; set; }

        public System.Data.Entity.DbSet<Car_Database.Models.Cars> Cars { get; set; }
    }
}
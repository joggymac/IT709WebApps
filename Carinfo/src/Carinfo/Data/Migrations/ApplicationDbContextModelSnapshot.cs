using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Carinfo.Data;

namespace Carinfo.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Car_Database.Models.CarBrand", b =>
                {
                    b.Property<int>("CarBrandID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("CarBrandID");

                    b.ToTable("CarBrand");
                });

            modelBuilder.Entity("Car_Database.Models.CarModel", b =>
                {
                    b.Property<int>("CarModelID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("CarModelID");

                    b.ToTable("CarModel");
                });

            modelBuilder.Entity("Car_Database.Models.Cylinder", b =>
                {
                    b.Property<int>("CylinderID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("CylinderID");

                    b.ToTable("Cylinder");
                });

            modelBuilder.Entity("Car_Database.Models.DriveType", b =>
                {
                    b.Property<int>("DrveTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("DrveTypeID");

                    b.ToTable("DriveType");
                });

            modelBuilder.Entity("Car_Database.Models.FuelType", b =>
                {
                    b.Property<int>("FuelTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Fuel")
                        .IsRequired();

                    b.HasKey("FuelTypeID");

                    b.ToTable("FuelType");
                });

            modelBuilder.Entity("Car_Database.Models.GearBox", b =>
                {
                    b.Property<int>("GearBoxID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GearBoxType")
                        .IsRequired();

                    b.HasKey("GearBoxID");

                    b.ToTable("GearBox");
                });

            modelBuilder.Entity("Carinfo.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Carinfo.Models.Subaru", b =>
                {
                    b.Property<int>("SubaruID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarModelID");

                    b.Property<int>("CylinderID");

                    b.Property<int>("Displacement");

                    b.Property<int>("DriveTypeID");

                    b.Property<int>("FuelTypeID");

                    b.Property<int>("GearBoxID");

                    b.Property<string>("Power");

                    b.Property<string>("Torque")
                        .IsRequired();

                    b.Property<int>("Weight");

                    b.Property<string>("Year");

                    b.Property<string>("img");

                    b.HasKey("SubaruID");

                    b.HasIndex("CarModelID");

                    b.HasIndex("CylinderID");

                    b.HasIndex("DriveTypeID");

                    b.HasIndex("FuelTypeID");

                    b.HasIndex("GearBoxID");

                    b.ToTable("Subaru");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Carinfo.Models.Subaru", b =>
                {
                    b.HasOne("Car_Database.Models.CarModel", "CarModels")
                        .WithMany()
                        .HasForeignKey("CarModelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Car_Database.Models.Cylinder", "Cylinders")
                        .WithMany()
                        .HasForeignKey("CylinderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Car_Database.Models.DriveType", "DriveTypes")
                        .WithMany()
                        .HasForeignKey("DriveTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Car_Database.Models.FuelType", "FuelTypes")
                        .WithMany()
                        .HasForeignKey("FuelTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Car_Database.Models.GearBox", "GearBoxes")
                        .WithMany()
                        .HasForeignKey("GearBoxID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Carinfo.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Carinfo.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Carinfo.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

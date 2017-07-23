namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarsID = c.Int(nullable: false, identity: true),
                        CarBrand = c.Int(nullable: false),
                        CarModel = c.Int(nullable: false),
                        Year = c.DateTime(nullable: false),
                        Displacement = c.Int(nullable: false),
                        Power = c.String(),
                        Torque = c.String(nullable: false),
                        FuelType = c.Int(nullable: false),
                        DriveType = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        CarBrands_CarBrandID = c.Int(),
                        CarModels_CarModelID = c.Int(),
                        DriveTypes_DrveTypeID = c.Int(),
                        FuelTypes_FuelTypeID = c.Int(),
                    })
                .PrimaryKey(t => t.CarsID)
                .ForeignKey("dbo.CarBrands", t => t.CarBrands_CarBrandID)
                .ForeignKey("dbo.CarModels", t => t.CarModels_CarModelID)
                .ForeignKey("dbo.DriveTypes", t => t.DriveTypes_DrveTypeID)
                .ForeignKey("dbo.FuelTypes", t => t.FuelTypes_FuelTypeID)
                .Index(t => t.CarBrands_CarBrandID)
                .Index(t => t.CarModels_CarModelID)
                .Index(t => t.DriveTypes_DrveTypeID)
                .Index(t => t.FuelTypes_FuelTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "FuelTypes_FuelTypeID", "dbo.FuelTypes");
            DropForeignKey("dbo.Cars", "DriveTypes_DrveTypeID", "dbo.DriveTypes");
            DropForeignKey("dbo.Cars", "CarModels_CarModelID", "dbo.CarModels");
            DropForeignKey("dbo.Cars", "CarBrands_CarBrandID", "dbo.CarBrands");
            DropIndex("dbo.Cars", new[] { "FuelTypes_FuelTypeID" });
            DropIndex("dbo.Cars", new[] { "DriveTypes_DrveTypeID" });
            DropIndex("dbo.Cars", new[] { "CarModels_CarModelID" });
            DropIndex("dbo.Cars", new[] { "CarBrands_CarBrandID" });
            DropTable("dbo.Cars");
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Carinfo.Data.Migrations
{
    public partial class all : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarBrand",
                columns: table => new
                {
                    CarBrandID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrand", x => x.CarBrandID);
                });

            migrationBuilder.CreateTable(
                name: "CarModel",
                columns: table => new
                {
                    CarModelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModel", x => x.CarModelID);
                });

            migrationBuilder.CreateTable(
                name: "Cylinder",
                columns: table => new
                {
                    CylinderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cylinder", x => x.CylinderID);
                });

            migrationBuilder.CreateTable(
                name: "DriveType",
                columns: table => new
                {
                    DrveTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriveType", x => x.DrveTypeID);
                });

            migrationBuilder.CreateTable(
                name: "FuelType",
                columns: table => new
                {
                    FuelTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fuel = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelType", x => x.FuelTypeID);
                });

            migrationBuilder.CreateTable(
                name: "GearBox",
                columns: table => new
                {
                    GearBoxID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GearBoxType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearBox", x => x.GearBoxID);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarBrandID = table.Column<int>(nullable: false),
                    CarModelID = table.Column<int>(nullable: false),
                    Displacement = table.Column<int>(nullable: false),
                    DriveTypeID = table.Column<int>(nullable: false),
                    FuelTypeID = table.Column<int>(nullable: false),
                    Power = table.Column<string>(nullable: true),
                    Torque = table.Column<string>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarID);
                    table.ForeignKey(
                        name: "FK_Car_CarBrand_CarBrandID",
                        column: x => x.CarBrandID,
                        principalTable: "CarBrand",
                        principalColumn: "CarBrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_CarModel_CarModelID",
                        column: x => x.CarModelID,
                        principalTable: "CarModel",
                        principalColumn: "CarModelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_DriveType_DriveTypeID",
                        column: x => x.DriveTypeID,
                        principalTable: "DriveType",
                        principalColumn: "DrveTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_FuelType_FuelTypeID",
                        column: x => x.FuelTypeID,
                        principalTable: "FuelType",
                        principalColumn: "FuelTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarBrandID",
                table: "Car",
                column: "CarBrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarModelID",
                table: "Car",
                column: "CarModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_DriveTypeID",
                table: "Car",
                column: "DriveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_FuelTypeID",
                table: "Car",
                column: "FuelTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Cylinder");

            migrationBuilder.DropTable(
                name: "GearBox");

            migrationBuilder.DropTable(
                name: "CarBrand");

            migrationBuilder.DropTable(
                name: "CarModel");

            migrationBuilder.DropTable(
                name: "DriveType");

            migrationBuilder.DropTable(
                name: "FuelType");
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Database_Cars.Data.Migrations
{
    public partial class fred : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Year = table.Column<DateTime>(nullable: false)
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
        }
    }
}

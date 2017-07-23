using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Carinfo.Data.Migrations
{
    public partial class cherry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.CreateTable(
                name: "Subaru",
                columns: table => new
                {
                    SubaruID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarModelID = table.Column<int>(nullable: false),
                    CylinderID = table.Column<int>(nullable: false),
                    Displacement = table.Column<int>(nullable: false),
                    DriveTypeID = table.Column<int>(nullable: false),
                    FuelTypeID = table.Column<int>(nullable: false),
                    GearBoxID = table.Column<int>(nullable: false),
                    Power = table.Column<string>(nullable: true),
                    Torque = table.Column<string>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Year = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subaru", x => x.SubaruID);
                    table.ForeignKey(
                        name: "FK_Subaru_CarModel_CarModelID",
                        column: x => x.CarModelID,
                        principalTable: "CarModel",
                        principalColumn: "CarModelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subaru_Cylinder_CylinderID",
                        column: x => x.CylinderID,
                        principalTable: "Cylinder",
                        principalColumn: "CylinderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subaru_DriveType_DriveTypeID",
                        column: x => x.DriveTypeID,
                        principalTable: "DriveType",
                        principalColumn: "DrveTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subaru_FuelType_FuelTypeID",
                        column: x => x.FuelTypeID,
                        principalTable: "FuelType",
                        principalColumn: "FuelTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subaru_GearBox_GearBoxID",
                        column: x => x.GearBoxID,
                        principalTable: "GearBox",
                        principalColumn: "GearBoxID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subaru_CarModelID",
                table: "Subaru",
                column: "CarModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Subaru_CylinderID",
                table: "Subaru",
                column: "CylinderID");

            migrationBuilder.CreateIndex(
                name: "IX_Subaru_DriveTypeID",
                table: "Subaru",
                column: "DriveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Subaru_FuelTypeID",
                table: "Subaru",
                column: "FuelTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Subaru_GearBoxID",
                table: "Subaru",
                column: "GearBoxID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subaru");

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarBrandID = table.Column<int>(nullable: false),
                    CarModelID = table.Column<int>(nullable: false),
                    CylinderID = table.Column<int>(nullable: false),
                    Displacement = table.Column<int>(nullable: false),
                    DriveTypeID = table.Column<int>(nullable: false),
                    FuelTypeID = table.Column<int>(nullable: false),
                    GearBoxID = table.Column<int>(nullable: false),
                    Power = table.Column<string>(nullable: true),
                    Torque = table.Column<string>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Year = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true)
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
                        name: "FK_Car_Cylinder_CylinderID",
                        column: x => x.CylinderID,
                        principalTable: "Cylinder",
                        principalColumn: "CylinderID",
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
                    table.ForeignKey(
                        name: "FK_Car_GearBox_GearBoxID",
                        column: x => x.GearBoxID,
                        principalTable: "GearBox",
                        principalColumn: "GearBoxID",
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
                name: "IX_Car_CylinderID",
                table: "Car",
                column: "CylinderID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_DriveTypeID",
                table: "Car",
                column: "DriveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_FuelTypeID",
                table: "Car",
                column: "FuelTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_GearBoxID",
                table: "Car",
                column: "GearBoxID");
        }
    }
}

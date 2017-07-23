using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Database.Data.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarBrand_CarBrandID",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarModel_CarModelID",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_DriveType_DriveTypeID",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_FuelType_FuelTypeID",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car",
                table: "Cars",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_CarBrand_CarBrandID",
                table: "Cars",
                column: "CarBrandID",
                principalTable: "CarBrand",
                principalColumn: "CarBrandID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_CarModel_CarModelID",
                table: "Cars",
                column: "CarModelID",
                principalTable: "CarModel",
                principalColumn: "CarModelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_DriveType_DriveTypeID",
                table: "Cars",
                column: "DriveTypeID",
                principalTable: "DriveType",
                principalColumn: "DrveTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_FuelType_FuelTypeID",
                table: "Cars",
                column: "FuelTypeID",
                principalTable: "FuelType",
                principalColumn: "FuelTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(
                name: "IX_Cars_FuelTypeID",
                table: "Cars",
                newName: "IX_Car_FuelTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_DriveTypeID",
                table: "Cars",
                newName: "IX_Car_DriveTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_CarModelID",
                table: "Cars",
                newName: "IX_Car_CarModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_CarBrandID",
                table: "Cars",
                newName: "IX_Car_CarBrandID");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "Car");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_CarBrand_CarBrandID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_CarModel_CarModelID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_DriveType_DriveTypeID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_FuelType_FuelTypeID",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car",
                table: "Car");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Car",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarBrand_CarBrandID",
                table: "Car",
                column: "CarBrandID",
                principalTable: "CarBrand",
                principalColumn: "CarBrandID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarModel_CarModelID",
                table: "Car",
                column: "CarModelID",
                principalTable: "CarModel",
                principalColumn: "CarModelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_DriveType_DriveTypeID",
                table: "Car",
                column: "DriveTypeID",
                principalTable: "DriveType",
                principalColumn: "DrveTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_FuelType_FuelTypeID",
                table: "Car",
                column: "FuelTypeID",
                principalTable: "FuelType",
                principalColumn: "FuelTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(
                name: "IX_Car_FuelTypeID",
                table: "Car",
                newName: "IX_Cars_FuelTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Car_DriveTypeID",
                table: "Car",
                newName: "IX_Cars_DriveTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Car_CarModelID",
                table: "Car",
                newName: "IX_Cars_CarModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Car_CarBrandID",
                table: "Car",
                newName: "IX_Cars_CarBrandID");

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "Cars");
        }
    }
}

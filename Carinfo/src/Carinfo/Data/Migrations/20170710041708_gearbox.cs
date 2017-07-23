using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Carinfo.Data.Migrations
{
    public partial class gearbox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CylinderID",
                table: "Car",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GearBoxID",
                table: "Car",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Car_CylinderID",
                table: "Car",
                column: "CylinderID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_GearBoxID",
                table: "Car",
                column: "GearBoxID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Cylinder_CylinderID",
                table: "Car",
                column: "CylinderID",
                principalTable: "Cylinder",
                principalColumn: "CylinderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_GearBox_GearBoxID",
                table: "Car",
                column: "GearBoxID",
                principalTable: "GearBox",
                principalColumn: "GearBoxID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Cylinder_CylinderID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_GearBox_GearBoxID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_CylinderID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_GearBoxID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CylinderID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "GearBoxID",
                table: "Car");
        }
    }
}

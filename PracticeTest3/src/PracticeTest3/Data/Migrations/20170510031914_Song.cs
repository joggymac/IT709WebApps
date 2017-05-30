using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticeTest3.Data.Migrations
{
    public partial class Song : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Song",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genre",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Artist",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Album",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Song");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genre",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Artist",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Album",
                nullable: true);
        }
    }
}

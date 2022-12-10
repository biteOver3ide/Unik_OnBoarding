using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class problemIntMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Kunder",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"),
                column: "Telefon",
                value: "41424344");

            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("f7709162-1bd8-4b99-9712-632603eeb167"),
                column: "Telefon",
                value: "41785968");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefon",
                table: "Kunder",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"),
                column: "Telefon",
                value: 41424344);

            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("f7709162-1bd8-4b99-9712-632603eeb167"),
                column: "Telefon",
                value: 41785968);
        }
    }
}

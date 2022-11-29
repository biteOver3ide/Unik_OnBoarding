using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class AddTelefon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"),
                column: "Telefon",
                value: 41424344);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"),
                column: "Telefon",
                value: 0);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class KundeUpdateCvrMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"),
                column: "Cvr",
                value: 78452152);

            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("f7709162-1bd8-4b99-9712-632603eeb167"),
                column: "Cvr",
                value: 29189900);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"),
                column: "Cvr",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("f7709162-1bd8-4b99-9712-632603eeb167"),
                column: "Cvr",
                value: 0);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class SeedingKundeProjekt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kunder",
                columns: new[] { "Kid", "Email", "Name", "Telefon" },
                values: new object[] { new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"), "aab@vejle.dk", "AAB Vejle", 0 });

            migrationBuilder.InsertData(
                table: "Projektes",
                columns: new[] { "ProjektId", "KundeId", "ProjektTitle" },
                values: new object[] { new Guid("e660a592-adcc-4046-9247-be98fbb5891f"), new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"), "Onboaring Kolding AAB" });

            migrationBuilder.InsertData(
                table: "Projektes",
                columns: new[] { "ProjektId", "KundeId", "ProjektTitle" },
                values: new object[] { new Guid("e7709162-a03f-4b4c-aeba-12573ef27676"), new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"), "Onboaring Vejle AAB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projektes",
                keyColumn: "ProjektId",
                keyValue: new Guid("e660a592-adcc-4046-9247-be98fbb5891f"));

            migrationBuilder.DeleteData(
                table: "Projektes",
                keyColumn: "ProjektId",
                keyValue: new Guid("e7709162-a03f-4b4c-aeba-12573ef27676"));

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"));
        }
    }
}

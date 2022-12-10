using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class KundeUpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Kunder",
                newName: "Fornavn");

            migrationBuilder.AddColumn<int>(
                name: "Cvr",
                table: "Kunder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Efternavn",
                table: "Kunder",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Firmanavn",
                table: "Kunder",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"),
                columns: new[] { "Efternavn", "Firmanavn", "Fornavn" },
                values: new object[] { "Hansen", "AAB", "Søren" });

            migrationBuilder.InsertData(
                table: "Kunder",
                columns: new[] { "Kid", "Adresse", "Cvr", "Efternavn", "Email", "Firmanavn", "Fornavn", "Telefon" },
                values: new object[] { new Guid("f7709162-1bd8-4b99-9712-632603eeb167"), "fynsvej 456", 0, "Petersen", "bo-to@vejle.dk", "Bo-To", "Jan", 41785968 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("f7709162-1bd8-4b99-9712-632603eeb167"));

            migrationBuilder.DropColumn(
                name: "Cvr",
                table: "Kunder");

            migrationBuilder.DropColumn(
                name: "Efternavn",
                table: "Kunder");

            migrationBuilder.DropColumn(
                name: "Firmanavn",
                table: "Kunder");

            migrationBuilder.RenameColumn(
                name: "Fornavn",
                table: "Kunder",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "Kid",
                keyValue: new Guid("c5121b63-1bd8-4b99-9712-632603eeb167"),
                column: "Name",
                value: "AAB Vejle");
        }
    }
}

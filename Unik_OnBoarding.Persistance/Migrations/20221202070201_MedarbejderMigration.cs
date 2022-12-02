using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class MedarbejderMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medarbejder",
                columns: table => new
                {
                    MedarbejderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fornavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Efternavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medarbejder", x => x.MedarbejderId);
                });

            migrationBuilder.CreateTable(
                name: "KompetenceEntity",
                columns: table => new
                {
                    KompetenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KompetenceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedarbejderEntityMedarbejderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KompetenceEntity", x => x.KompetenceId);
                    table.ForeignKey(
                        name: "FK_KompetenceEntity_Medarbejder_MedarbejderEntityMedarbejderId",
                        column: x => x.MedarbejderEntityMedarbejderId,
                        principalTable: "Medarbejder",
                        principalColumn: "MedarbejderId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_KompetenceEntity_MedarbejderEntityMedarbejderId",
                table: "KompetenceEntity",
                column: "MedarbejderEntityMedarbejderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KompetenceEntity");

            migrationBuilder.DropTable(
                name: "Medarbejder");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class changeKompMirgartion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MedarbejderEntityMedarbejderId",
                schema: "Unik",
                table: "Kompetencerne",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kompetencerne_MedarbejderEntityMedarbejderId",
                schema: "Unik",
                table: "Kompetencerne",
                column: "MedarbejderEntityMedarbejderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kompetencerne_Medarbejder_MedarbejderEntityMedarbejderId",
                schema: "Unik",
                table: "Kompetencerne",
                column: "MedarbejderEntityMedarbejderId",
                principalSchema: "Unik",
                principalTable: "Medarbejder",
                principalColumn: "MedarbejderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kompetencerne_Medarbejder_MedarbejderEntityMedarbejderId",
                schema: "Unik",
                table: "Kompetencerne");

            migrationBuilder.DropIndex(
                name: "IX_Kompetencerne_MedarbejderEntityMedarbejderId",
                schema: "Unik",
                table: "Kompetencerne");

            migrationBuilder.DropColumn(
                name: "MedarbejderEntityMedarbejderId",
                schema: "Unik",
                table: "Kompetencerne");
        }
    }
}

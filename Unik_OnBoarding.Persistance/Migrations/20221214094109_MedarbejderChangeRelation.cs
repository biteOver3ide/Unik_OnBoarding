using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class MedarbejderChangeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "MedarbejderId",
                schema: "Unik",
                table: "Kompetencerne",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Kompetencerne_MedarbejderId",
                schema: "Unik",
                table: "Kompetencerne",
                column: "MedarbejderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kompetencerne_Medarbejder_MedarbejderId",
                schema: "Unik",
                table: "Kompetencerne",
                column: "MedarbejderId",
                principalSchema: "Unik",
                principalTable: "Medarbejder",
                principalColumn: "MedarbejderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kompetencerne_Medarbejder_MedarbejderId",
                schema: "Unik",
                table: "Kompetencerne");

            migrationBuilder.DropIndex(
                name: "IX_Kompetencerne_MedarbejderId",
                schema: "Unik",
                table: "Kompetencerne");

            migrationBuilder.DropColumn(
                name: "MedarbejderId",
                schema: "Unik",
                table: "Kompetencerne");

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
    }
}

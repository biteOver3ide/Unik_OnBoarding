using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class EnumMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kompetencerne_Medarbejder_MedarbejderEntityMedarbejderId",
                table: "Kompetencerne");

            migrationBuilder.DropIndex(
                name: "IX_Kompetencerne_MedarbejderEntityMedarbejderId",
                table: "Kompetencerne");

            migrationBuilder.DropColumn(
                name: "MedarbejderEntityMedarbejderId",
                table: "Kompetencerne");

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "Medarbejder",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Job",
                table: "Medarbejder",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "MedarbejderEntityMedarbejderId",
                table: "Kompetencerne",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kompetencerne_MedarbejderEntityMedarbejderId",
                table: "Kompetencerne",
                column: "MedarbejderEntityMedarbejderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kompetencerne_Medarbejder_MedarbejderEntityMedarbejderId",
                table: "Kompetencerne",
                column: "MedarbejderEntityMedarbejderId",
                principalTable: "Medarbejder",
                principalColumn: "MedarbejderId");
        }
    }
}

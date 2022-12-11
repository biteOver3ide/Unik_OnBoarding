using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class KompetencerUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KompetenceName",
                table: "Kompetencerne");

            migrationBuilder.AddColumn<int>(
                name: "Job",
                table: "Kompetencerne",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Job",
                table: "Kompetencerne");

            migrationBuilder.AddColumn<string>(
                name: "KompetenceName",
                table: "Kompetencerne",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

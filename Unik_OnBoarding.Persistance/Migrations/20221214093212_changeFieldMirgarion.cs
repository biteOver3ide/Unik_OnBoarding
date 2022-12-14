using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class changeFieldMirgarion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Unik");

            migrationBuilder.RenameTable(
                name: "Projektes",
                newName: "Projektes",
                newSchema: "Unik");

            migrationBuilder.RenameTable(
                name: "Opgaver",
                newName: "Opgaver",
                newSchema: "Unik");

            migrationBuilder.RenameTable(
                name: "Medarbejder",
                newName: "Medarbejder",
                newSchema: "Unik");

            migrationBuilder.RenameTable(
                name: "Kunder",
                newName: "Kunder",
                newSchema: "Unik");

            migrationBuilder.RenameTable(
                name: "Kompetencerne",
                newName: "Kompetencerne",
                newSchema: "Unik");

            migrationBuilder.RenameTable(
                name: "Bookinger",
                newName: "Bookinger",
                newSchema: "Unik");

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                schema: "Unik",
                table: "Medarbejder",
                type: "nvarchar(24)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Beskrivelse",
                schema: "Unik",
                table: "Bookinger",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beskrivelse",
                schema: "Unik",
                table: "Bookinger");

            migrationBuilder.RenameTable(
                name: "Projektes",
                schema: "Unik",
                newName: "Projektes");

            migrationBuilder.RenameTable(
                name: "Opgaver",
                schema: "Unik",
                newName: "Opgaver");

            migrationBuilder.RenameTable(
                name: "Medarbejder",
                schema: "Unik",
                newName: "Medarbejder");

            migrationBuilder.RenameTable(
                name: "Kunder",
                schema: "Unik",
                newName: "Kunder");

            migrationBuilder.RenameTable(
                name: "Kompetencerne",
                schema: "Unik",
                newName: "Kompetencerne");

            migrationBuilder.RenameTable(
                name: "Bookinger",
                schema: "Unik",
                newName: "Bookinger");

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "Medarbejder",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)");
        }
    }
}

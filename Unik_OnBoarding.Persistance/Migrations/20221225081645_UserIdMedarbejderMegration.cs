using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class UserIdMedarbejderMegration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

	        migrationBuilder.AddColumn<string>(
                name: "UserId",
                schema: "Unik",
                table: "Medarbejder",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "Unik",
                table: "Medarbejder");

        }
    }
}

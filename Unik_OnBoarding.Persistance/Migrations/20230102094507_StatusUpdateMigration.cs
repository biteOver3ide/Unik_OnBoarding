using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class StatusUpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                schema: "Unik",
                table: "Opgaver");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                schema: "Unik",
                table: "Bookinger",
                type: "nvarchar(24)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                schema: "Unik",
                table: "Bookinger");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                schema: "Unik",
                table: "Opgaver",
                type: "nvarchar(24)",
                nullable: false,
                defaultValue: "");
        }
    }
}

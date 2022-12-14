using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class MedarbejderChangeRelationerdfdff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KompetenceEntityMedarbejderEntity",
                schema: "Unik");

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

            migrationBuilder.CreateTable(
                name: "KompetenceEntityMedarbejderEntity",
                schema: "Unik",
                columns: table => new
                {
                    KompetencerKompetenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedarbejderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KompetenceEntityMedarbejderEntity", x => new { x.KompetencerKompetenceId, x.MedarbejderId });
                    table.ForeignKey(
                        name: "FK_KompetenceEntityMedarbejderEntity_Kompetencerne_KompetencerKompetenceId",
                        column: x => x.KompetencerKompetenceId,
                        principalSchema: "Unik",
                        principalTable: "Kompetencerne",
                        principalColumn: "KompetenceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KompetenceEntityMedarbejderEntity_Medarbejder_MedarbejderId",
                        column: x => x.MedarbejderId,
                        principalSchema: "Unik",
                        principalTable: "Medarbejder",
                        principalColumn: "MedarbejderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KompetenceEntityMedarbejderEntity_MedarbejderId",
                schema: "Unik",
                table: "KompetenceEntityMedarbejderEntity",
                column: "MedarbejderId");
        }
    }
}

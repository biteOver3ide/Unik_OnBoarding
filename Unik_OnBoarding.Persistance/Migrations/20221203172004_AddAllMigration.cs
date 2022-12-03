using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unik_OnBoarding.Persistance.Migrations
{
    public partial class AddAllMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KompetenceEntity_Medarbejder_MedarbejderEntityMedarbejderId",
                table: "KompetenceEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KompetenceEntity",
                table: "KompetenceEntity");

            migrationBuilder.RenameTable(
                name: "KompetenceEntity",
                newName: "Kompetencerne");

            migrationBuilder.RenameIndex(
                name: "IX_KompetenceEntity_MedarbejderEntityMedarbejderId",
                table: "Kompetencerne",
                newName: "IX_Kompetencerne_MedarbejderEntityMedarbejderId");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Projektes",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kompetencerne",
                table: "Kompetencerne",
                column: "KompetenceId");

            migrationBuilder.CreateTable(
                name: "Opgaver",
                columns: table => new
                {
                    OpgaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpgaveName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opgaver", x => x.OpgaveId);
                });

            migrationBuilder.CreateTable(
                name: "Bookinger",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjektId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpgaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedarbejderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookinger", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Bookinger_Medarbejder_MedarbejderId",
                        column: x => x.MedarbejderId,
                        principalTable: "Medarbejder",
                        principalColumn: "MedarbejderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookinger_Opgaver_OpgaveId",
                        column: x => x.OpgaveId,
                        principalTable: "Opgaver",
                        principalColumn: "OpgaveId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookinger_Projektes_ProjektId",
                        column: x => x.ProjektId,
                        principalTable: "Projektes",
                        principalColumn: "ProjektId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookinger_MedarbejderId",
                table: "Bookinger",
                column: "MedarbejderId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookinger_OpgaveId",
                table: "Bookinger",
                column: "OpgaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookinger_ProjektId",
                table: "Bookinger",
                column: "ProjektId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kompetencerne_Medarbejder_MedarbejderEntityMedarbejderId",
                table: "Kompetencerne",
                column: "MedarbejderEntityMedarbejderId",
                principalTable: "Medarbejder",
                principalColumn: "MedarbejderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kompetencerne_Medarbejder_MedarbejderEntityMedarbejderId",
                table: "Kompetencerne");

            migrationBuilder.DropTable(
                name: "Bookinger");

            migrationBuilder.DropTable(
                name: "Opgaver");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kompetencerne",
                table: "Kompetencerne");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Projektes");

            migrationBuilder.RenameTable(
                name: "Kompetencerne",
                newName: "KompetenceEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Kompetencerne_MedarbejderEntityMedarbejderId",
                table: "KompetenceEntity",
                newName: "IX_KompetenceEntity_MedarbejderEntityMedarbejderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KompetenceEntity",
                table: "KompetenceEntity",
                column: "KompetenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_KompetenceEntity_Medarbejder_MedarbejderEntityMedarbejderId",
                table: "KompetenceEntity",
                column: "MedarbejderEntityMedarbejderId",
                principalTable: "Medarbejder",
                principalColumn: "MedarbejderId");
        }
    }
}

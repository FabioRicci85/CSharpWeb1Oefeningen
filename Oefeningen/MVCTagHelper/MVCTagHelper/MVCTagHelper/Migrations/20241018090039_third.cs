using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTagHelper.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Medewerker",
                table: "Medewerker");

            migrationBuilder.RenameTable(
                name: "Medewerker",
                newName: "Medewerkers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medewerkers",
                table: "Medewerkers",
                column: "MedewerkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Medewerkers_AfdelingId",
                table: "Medewerkers",
                column: "AfdelingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medewerkers_Afdelingen_AfdelingId",
                table: "Medewerkers",
                column: "AfdelingId",
                principalTable: "Afdelingen",
                principalColumn: "AfdelingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medewerkers_Afdelingen_AfdelingId",
                table: "Medewerkers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medewerkers",
                table: "Medewerkers");

            migrationBuilder.DropIndex(
                name: "IX_Medewerkers_AfdelingId",
                table: "Medewerkers");

            migrationBuilder.RenameTable(
                name: "Medewerkers",
                newName: "Medewerker");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medewerker",
                table: "Medewerker",
                column: "MedewerkerId");
        }
    }
}

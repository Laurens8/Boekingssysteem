using Microsoft.EntityFrameworkCore.Migrations;

namespace Boekingssysteem.Migrations
{
    public partial class CustomUserPersoon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersoonPersoneelnummer",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersoonPersoneelnummer",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers",
                column: "PersoonPersoneelnummer");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Persoon_PersoonPersoneelnummer",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers",
                column: "PersoonPersoneelnummer",
                principalSchema: "TM_Boekingssysteem",
                principalTable: "Persoon",
                principalColumn: "Personeelnummer",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Persoon_PersoonPersoneelnummer",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersoonPersoneelnummer",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersoonPersoneelnummer",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers");
        }
    }
}

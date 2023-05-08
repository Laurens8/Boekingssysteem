using Microsoft.EntityFrameworkCore.Migrations;

namespace Boekingssysteem.Migrations
{
    public partial class wachtwoord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Wachtwoord",
                schema: "TM_Boekingssysteem",
                table: "Persoon",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wachtwoord",
                schema: "TM_Boekingssysteem",
                table: "Persoon");
        }
    }
}

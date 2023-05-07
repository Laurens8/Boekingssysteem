using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boekingssysteem.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Geboortedatum",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Personeelnummer",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voornaam",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Personeelnummer",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Voornaam",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "Geboortedatum",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

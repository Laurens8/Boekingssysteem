using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boekingssysteem.Migrations
{
    public partial class CustomUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Geboortedatum",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Naam",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Geboortedatum",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Naam",
                schema: "TM_Boekingssysteem",
                table: "AspNetUsers");
        }
    }
}

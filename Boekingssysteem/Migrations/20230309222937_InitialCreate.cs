using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boekingssysteem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Boekingssysteem");

            migrationBuilder.CreateTable(
                name: "Afwezigheid",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    AfwezigheidID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersoonID = table.Column<int>(nullable: false),
                    Begindatum = table.Column<DateTime>(nullable: true),
                    EindDatum = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afwezigheid", x => x.AfwezigheidID);
                });

            migrationBuilder.CreateTable(
                name: "Persoon",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    PersoonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Voornaam = table.Column<string>(nullable: false),
                    Admin = table.Column<bool>(nullable: false),
                    Personeelnummer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persoon", x => x.PersoonID);
                });

            migrationBuilder.CreateTable(
                name: "PersoonVakStatus",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    PersoonVakStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersoonID = table.Column<int>(nullable: false),
                    VakID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoonVakStatus", x => x.PersoonVakStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    StatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersoonID = table.Column<int>(nullable: false),
                    Aanwezig = table.Column<bool>(nullable: true),
                    Onbekend = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Vak",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    VakID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vak", x => x.VakID);
                });

            migrationBuilder.InsertData(
                schema: "Boekingssysteem",
                table: "Afwezigheid",
                columns: new[] { "AfwezigheidID", "Begindatum", "EindDatum", "PersoonID" },
                values: new object[] { 1, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                schema: "Boekingssysteem",
                table: "Persoon",
                columns: new[] { "PersoonID", "Admin", "Naam", "Personeelnummer", "Voornaam" },
                values: new object[,]
                {
                    { 1, true, "Mathieu", "R0901658", "Christophe" },
                    { 2, true, "De Wit", "R0658604", "Laurens" },
                    { 3, true, "Boeckx", "R0658604", "Lender" }
                });

            migrationBuilder.InsertData(
                schema: "Boekingssysteem",
                table: "PersoonVakStatus",
                columns: new[] { "PersoonVakStatusID", "PersoonID", "VakID" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                schema: "Boekingssysteem",
                table: "Status",
                columns: new[] { "StatusID", "Aanwezig", "Onbekend", "PersoonID" },
                values: new object[] { 1, true, false, 1 });

            migrationBuilder.InsertData(
                schema: "Boekingssysteem",
                table: "Vak",
                columns: new[] { "VakID", "Naam" },
                values: new object[] { 1, "Informatica" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afwezigheid",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "Persoon",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "PersoonVakStatus",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "Status",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "Vak",
                schema: "Boekingssysteem");
        }
    }
}

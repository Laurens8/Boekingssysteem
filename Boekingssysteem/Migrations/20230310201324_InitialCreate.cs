﻿using System;
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
                name: "Functie",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    FunctieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functie", x => x.FunctieID);
                });

            migrationBuilder.CreateTable(
                name: "Persoon",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    Personeelnummer = table.Column<string>(maxLength: 8, nullable: false),
                    Naam = table.Column<string>(nullable: false),
                    Voornaam = table.Column<string>(nullable: false),
                    Admin = table.Column<bool>(nullable: false),
                    Aanwezig = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persoon", x => x.Personeelnummer);
                });

            migrationBuilder.CreateTable(
                name: "Richting",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    RichtingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Richting", x => x.RichtingID);
                });

            migrationBuilder.CreateTable(
                name: "Afwezigheid",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    AfwezigheidID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personeelnummer = table.Column<string>(maxLength: 8, nullable: false),
                    Begindatum = table.Column<DateTime>(nullable: false),
                    EindDatum = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afwezigheid", x => x.AfwezigheidID);
                    table.ForeignKey(
                        name: "FK_Afwezigheid_Persoon_Personeelnummer",
                        column: x => x.Personeelnummer,
                        principalSchema: "Boekingssysteem",
                        principalTable: "Persoon",
                        principalColumn: "Personeelnummer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersoonFunctie",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    PersoonFunctieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personeelnummer = table.Column<string>(maxLength: 8, nullable: false),
                    FunctieID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoonFunctie", x => x.PersoonFunctieID);
                    table.ForeignKey(
                        name: "FK_PersoonFunctie_Functie_FunctieID",
                        column: x => x.FunctieID,
                        principalSchema: "Boekingssysteem",
                        principalTable: "Functie",
                        principalColumn: "FunctieID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersoonFunctie_Persoon_Personeelnummer",
                        column: x => x.Personeelnummer,
                        principalSchema: "Boekingssysteem",
                        principalTable: "Persoon",
                        principalColumn: "Personeelnummer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersoonRichting",
                schema: "Boekingssysteem",
                columns: table => new
                {
                    Personeelnummer = table.Column<string>(maxLength: 8, nullable: false),
                    RichtingID = table.Column<int>(nullable: false),
                    PersoonRichtingID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoonRichting", x => new { x.RichtingID, x.Personeelnummer });
                    table.ForeignKey(
                        name: "FK_PersoonRichting_Persoon_Personeelnummer",
                        column: x => x.Personeelnummer,
                        principalSchema: "Boekingssysteem",
                        principalTable: "Persoon",
                        principalColumn: "Personeelnummer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersoonRichting_Richting_RichtingID",
                        column: x => x.RichtingID,
                        principalSchema: "Boekingssysteem",
                        principalTable: "Richting",
                        principalColumn: "RichtingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Boekingssysteem",
                table: "Functie",
                columns: new[] { "FunctieID", "Naam" },
                values: new object[,]
                {
                    { 1, "Leerling" },
                    { 2, "Administratief personeel" },
                    { 3, "Leerkracht" }
                });

            migrationBuilder.InsertData(
                schema: "Boekingssysteem",
                table: "Persoon",
                columns: new[] { "Personeelnummer", "Aanwezig", "Admin", "Naam", "Voornaam" },
                values: new object[,]
                {
                    { "R0901658", true, true, "Mathieu", "Christophe" },
                    { "R0901293", true, true, "De Wit", "Laurens" },
                    { "R0658604", true, true, "Boeckx", "Lender" },
                    { "R0123456", true, false, "Bellemans", "Johan" },
                    { "R0123457", true, true, "Janssens", "Jan" }
                });

            migrationBuilder.InsertData(
                schema: "Boekingssysteem",
                table: "Richting",
                columns: new[] { "RichtingID", "Naam" },
                values: new object[,]
                {
                    { 1, "Informatica" },
                    { 2, "Verpleegkunde" }
                });

            migrationBuilder.InsertData(
                schema: "Boekingssysteem",
                table: "Afwezigheid",
                columns: new[] { "AfwezigheidID", "Begindatum", "EindDatum", "Personeelnummer" },
                values: new object[] { 1, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "R0901658" });

            migrationBuilder.InsertData(
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                columns: new[] { "PersoonFunctieID", "FunctieID", "Personeelnummer" },
                values: new object[,]
                {
                    { 1, 1, "R0901658" },
                    { 3, 1, "R0901293" },
                    { 2, 1, "R0658604" },
                    { 4, 3, "R0123456" },
                    { 5, 2, "R0123457" }
                });

            migrationBuilder.InsertData(
                schema: "Boekingssysteem",
                table: "PersoonRichting",
                columns: new[] { "RichtingID", "Personeelnummer", "PersoonRichtingID" },
                values: new object[,]
                {
                    { 1, "R0901658", 1 },
                    { 1, "R0658604", 2 },
                    { 1, "R0901293", 3 },
                    { 2, "R0123456", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Afwezigheid_Personeelnummer",
                schema: "Boekingssysteem",
                table: "Afwezigheid",
                column: "Personeelnummer");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonFunctie_FunctieID",
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                column: "FunctieID");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonFunctie_Personeelnummer",
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                column: "Personeelnummer");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonRichting_Personeelnummer",
                schema: "Boekingssysteem",
                table: "PersoonRichting",
                column: "Personeelnummer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afwezigheid",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "PersoonFunctie",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "PersoonRichting",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "Functie",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "Persoon",
                schema: "Boekingssysteem");

            migrationBuilder.DropTable(
                name: "Richting",
                schema: "Boekingssysteem");
        }
    }
}

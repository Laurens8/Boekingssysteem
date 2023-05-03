using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boekingssysteem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "TM_Boekingssysteem");

            migrationBuilder.CreateTable(
                name: "Functie",
                schema: "TM_Boekingssysteem",
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
                schema: "TM_Boekingssysteem",
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
                schema: "TM_Boekingssysteem",
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
                schema: "TM_Boekingssysteem",
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
                        principalSchema: "TM_Boekingssysteem",
                        principalTable: "Persoon",
                        principalColumn: "Personeelnummer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersoonFunctie",
                schema: "TM_Boekingssysteem",
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
                        principalSchema: "TM_Boekingssysteem",
                        principalTable: "Functie",
                        principalColumn: "FunctieID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersoonFunctie_Persoon_Personeelnummer",
                        column: x => x.Personeelnummer,
                        principalSchema: "TM_Boekingssysteem",
                        principalTable: "Persoon",
                        principalColumn: "Personeelnummer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersoonRichting",
                schema: "TM_Boekingssysteem",
                columns: table => new
                {
                    PersoonRichtingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personeelnummer = table.Column<string>(maxLength: 8, nullable: false),
                    RichtingID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoonRichting", x => x.PersoonRichtingID);
                    table.ForeignKey(
                        name: "FK_PersoonRichting_Persoon_Personeelnummer",
                        column: x => x.Personeelnummer,
                        principalSchema: "TM_Boekingssysteem",
                        principalTable: "Persoon",
                        principalColumn: "Personeelnummer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersoonRichting_Richting_RichtingID",
                        column: x => x.RichtingID,
                        principalSchema: "TM_Boekingssysteem",
                        principalTable: "Richting",
                        principalColumn: "RichtingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Afwezigheid_Personeelnummer",
                schema: "TM_Boekingssysteem",
                table: "Afwezigheid",
                column: "Personeelnummer");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonFunctie_FunctieID",
                schema: "TM_Boekingssysteem",
                table: "PersoonFunctie",
                column: "FunctieID");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonFunctie_Personeelnummer",
                schema: "TM_Boekingssysteem",
                table: "PersoonFunctie",
                column: "Personeelnummer");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonRichting_Personeelnummer",
                schema: "TM_Boekingssysteem",
                table: "PersoonRichting",
                column: "Personeelnummer");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonRichting_RichtingID",
                schema: "TM_Boekingssysteem",
                table: "PersoonRichting",
                column: "RichtingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afwezigheid",
                schema: "TM_Boekingssysteem");

            migrationBuilder.DropTable(
                name: "PersoonFunctie",
                schema: "TM_Boekingssysteem");

            migrationBuilder.DropTable(
                name: "PersoonRichting",
                schema: "TM_Boekingssysteem");

            migrationBuilder.DropTable(
                name: "Functie",
                schema: "TM_Boekingssysteem");

            migrationBuilder.DropTable(
                name: "Persoon",
                schema: "TM_Boekingssysteem");

            migrationBuilder.DropTable(
                name: "Richting",
                schema: "TM_Boekingssysteem");
        }
    }
}

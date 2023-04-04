using Microsoft.EntityFrameworkCore.Migrations;

namespace Boekingssysteem.Migrations
{
    public partial class Kleinetypfout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersoonRichting",
                schema: "TM_Boekingssysteem",
                table: "PersoonRichting");

            migrationBuilder.DropIndex(
                name: "IX_PersoonRichting_RichtingID",
                schema: "TM_Boekingssysteem",
                table: "PersoonRichting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersoonFunctie",
                schema: "TM_Boekingssysteem",
                table: "PersoonFunctie");

            migrationBuilder.DropIndex(
                name: "IX_PersoonFunctie_FunctieID",
                schema: "TM_Boekingssysteem",
                table: "PersoonFunctie");

            migrationBuilder.RenameColumn(
                name: "EindDatum",
                schema: "TM_Boekingssysteem",
                table: "Afwezigheid",
                newName: "Einddatum");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersoonRichting",
                schema: "TM_Boekingssysteem",
                table: "PersoonRichting",
                columns: new[] { "RichtingID", "Personeelnummer" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersoonFunctie",
                schema: "TM_Boekingssysteem",
                table: "PersoonFunctie",
                columns: new[] { "FunctieID", "Personeelnummer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersoonRichting",
                schema: "TM_Boekingssysteem",
                table: "PersoonRichting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersoonFunctie",
                schema: "TM_Boekingssysteem",
                table: "PersoonFunctie");

            migrationBuilder.RenameColumn(
                name: "Einddatum",
                schema: "TM_Boekingssysteem",
                table: "Afwezigheid",
                newName: "EindDatum");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersoonRichting",
                schema: "TM_Boekingssysteem",
                table: "PersoonRichting",
                column: "PersoonRichtingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersoonFunctie",
                schema: "TM_Boekingssysteem",
                table: "PersoonFunctie",
                column: "PersoonFunctieID");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonRichting_RichtingID",
                schema: "TM_Boekingssysteem",
                table: "PersoonRichting",
                column: "RichtingID");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonFunctie_FunctieID",
                schema: "TM_Boekingssysteem",
                table: "PersoonFunctie",
                column: "FunctieID");
        }
    }
}

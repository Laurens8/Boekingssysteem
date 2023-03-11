using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boekingssysteem.Migrations
{
    public partial class Intialiser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "Afwezigheid",
                keyColumn: "AfwezigheidID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                keyColumns: new[] { "FunctieID", "Personeelnummer" },
                keyValues: new object[] { 1, "R0658604" });

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                keyColumns: new[] { "FunctieID", "Personeelnummer" },
                keyValues: new object[] { 1, "R0901293" });

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                keyColumns: new[] { "FunctieID", "Personeelnummer" },
                keyValues: new object[] { 1, "R0901658" });

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                keyColumns: new[] { "FunctieID", "Personeelnummer" },
                keyValues: new object[] { 2, "R0123457" });

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "PersoonFunctie",
                keyColumns: new[] { "FunctieID", "Personeelnummer" },
                keyValues: new object[] { 3, "R0123456" });

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "PersoonRichting",
                keyColumns: new[] { "RichtingID", "Personeelnummer" },
                keyValues: new object[] { 1, "R0658604" });

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "PersoonRichting",
                keyColumns: new[] { "RichtingID", "Personeelnummer" },
                keyValues: new object[] { 1, "R0901293" });

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "PersoonRichting",
                keyColumns: new[] { "RichtingID", "Personeelnummer" },
                keyValues: new object[] { 1, "R0901658" });

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "PersoonRichting",
                keyColumns: new[] { "RichtingID", "Personeelnummer" },
                keyValues: new object[] { 2, "R0123456" });

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "Functie",
                keyColumn: "FunctieID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "Functie",
                keyColumn: "FunctieID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "Functie",
                keyColumn: "FunctieID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "Persoon",
                keyColumn: "Personeelnummer",
                keyValue: "R0123456");

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "Persoon",
                keyColumn: "Personeelnummer",
                keyValue: "R0123457");

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "Persoon",
                keyColumn: "Personeelnummer",
                keyValue: "R0658604");

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "Persoon",
                keyColumn: "Personeelnummer",
                keyValue: "R0901293");

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "Persoon",
                keyColumn: "Personeelnummer",
                keyValue: "R0901658");

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "Richting",
                keyColumn: "RichtingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Boekingssysteem",
                table: "Richting",
                keyColumn: "RichtingID",
                keyValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "FunctieID", "Personeelnummer", "PersoonFunctieID" },
                values: new object[,]
                {
                    { 1, "R0901658", 1 },
                    { 1, "R0901293", 3 },
                    { 1, "R0658604", 2 },
                    { 3, "R0123456", 4 },
                    { 2, "R0123457", 5 }
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
        }
    }
}

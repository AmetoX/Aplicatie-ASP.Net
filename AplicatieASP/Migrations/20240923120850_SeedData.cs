using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AplicatieASP.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "webasp",
                table: "FiseDeLucru",
                columns: new[] { "Id", "Date", "Number" },
                values: new object[,]
                {
                    { 1, "2021-01-01", "1" },
                    { 2, "2021-01-02", "2" }
                });

            migrationBuilder.InsertData(
                schema: "webasp",
                table: "Users",
                columns: new[] { "Id", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "John", "1234" },
                    { 2, "Jane", "5678" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "webasp",
                table: "FiseDeLucru",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "webasp",
                table: "FiseDeLucru",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "webasp",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "webasp",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

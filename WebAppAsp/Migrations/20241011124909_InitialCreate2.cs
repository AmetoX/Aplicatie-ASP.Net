using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppAsp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "FiseDeLucru",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.DeleteData(
                schema: "webasp",
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                schema: "webasp",
                table: "FiseDeLucru",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                schema: "webasp",
                table: "FiseDeLucru",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "City",
                schema: "webasp",
                table: "FiseDeLucru",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "First_Name",
                schema: "webasp",
                table: "FiseDeLucru",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Last_Name",
                schema: "webasp",
                table: "FiseDeLucru",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "State",
                schema: "webasp",
                table: "FiseDeLucru",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Zip_Code",
                schema: "webasp",
                table: "FiseDeLucru",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                schema: "webasp",
                table: "FiseDeLucru");

            migrationBuilder.DropColumn(
                name: "City",
                schema: "webasp",
                table: "FiseDeLucru");

            migrationBuilder.DropColumn(
                name: "First_Name",
                schema: "webasp",
                table: "FiseDeLucru");

            migrationBuilder.DropColumn(
                name: "Last_Name",
                schema: "webasp",
                table: "FiseDeLucru");

            migrationBuilder.DropColumn(
                name: "State",
                schema: "webasp",
                table: "FiseDeLucru");

            migrationBuilder.DropColumn(
                name: "Zip_Code",
                schema: "webasp",
                table: "FiseDeLucru");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                schema: "webasp",
                table: "FiseDeLucru",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                schema: "webasp",
                table: "FiseDeLucru",
                columns: new[] { "Id", "Date", "GPS", "Number" },
                values: new object[,]
                {
                    { 1, "2021-02-01", "124.456.789", "1" },
                    { 2, "2021-02-02", "987.653.321", "2" },
                    { 3, "2021-03-03", "987.624.321", "3" }
                });

            migrationBuilder.InsertData(
                schema: "webasp",
                table: "Users",
                columns: new[] { "Id", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "John", "1234" },
                    { 2, "Jane", "5678" },
                    { 3, "Admin", "admin" }
                });
        }
    }
}

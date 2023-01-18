using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetPlayground.Migrations
{
    /// <inheritdoc />
    public partial class dodanaOsoba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DatumKreiranja",
                table: "Cars",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ime = table.Column<string>(type: "TEXT", nullable: false),
                    Prezime = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "TEXT", nullable: true),
                    NajdrazaHrana = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: "09.01.2023");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: "09.01.2023");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumKreiranja",
                value: "09.01.2023");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumKreiranja",
                value: "09.01.2023");

            migrationBuilder.InsertData(
                table: "Osoba",
                columns: new[] { "Id", "DatumKreiranja", "DatumRodjenja", "Email", "Ime", "NajdrazaHrana", "Prezime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 18, 14, 57, 41, 591, DateTimeKind.Local).AddTicks(7671), new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "amor@gmx.com", "Amor", "Krompir", "Osmić" },
                    { 2, new DateTime(2023, 1, 18, 14, 57, 41, 591, DateTimeKind.Local).AddTicks(7707), new DateTime(1995, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "sara@gmx.com", "Sara", "Pizza", "Šahinpašić" },
                    { 3, null, new DateTime(1998, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ines@gmx.com", "Ines", "Špagete", "Osmić" },
                    { 4, null, new DateTime(1994, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "jasko@gmx.com", "Jasko", "Burek", "Kreho" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Osoba");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DatumKreiranja",
                table: "Cars",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateOnly(2023, 1, 9));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateOnly(2023, 1, 9));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumKreiranja",
                value: new DateOnly(2023, 1, 9));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumKreiranja",
                value: new DateOnly(2023, 1, 9));
        }
    }
}

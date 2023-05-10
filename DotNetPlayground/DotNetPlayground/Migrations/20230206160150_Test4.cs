using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetPlayground.Migrations
{
    /// <inheritdoc />
    public partial class Test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bezeze",
                table: "Bezeze");

            migrationBuilder.RenameTable(
                name: "Bezeze",
                newName: "nananana");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nananana",
                table: "nananana",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2023, 2, 6, 17, 1, 50, 650, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2023, 2, 6, 17, 1, 50, 650, DateTimeKind.Local).AddTicks(5826));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_nananana",
                table: "nananana");

            migrationBuilder.RenameTable(
                name: "nananana",
                newName: "Bezeze");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bezeze",
                table: "Bezeze",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2023, 2, 6, 17, 1, 9, 754, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2023, 2, 6, 17, 1, 9, 754, DateTimeKind.Local).AddTicks(6121));
        }
    }
}

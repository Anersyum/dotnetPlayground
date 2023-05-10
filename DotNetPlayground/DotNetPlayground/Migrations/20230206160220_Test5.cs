using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetPlayground.Migrations
{
    /// <inheritdoc />
    public partial class Test5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_nananana",
                table: "nananana");

            migrationBuilder.RenameTable(
                name: "nananana",
                newName: "BezvezeModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BezvezeModels",
                table: "BezvezeModels",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2023, 2, 6, 17, 2, 20, 466, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2023, 2, 6, 17, 2, 20, 466, DateTimeKind.Local).AddTicks(8650));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BezvezeModels",
                table: "BezvezeModels");

            migrationBuilder.RenameTable(
                name: "BezvezeModels",
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
    }
}

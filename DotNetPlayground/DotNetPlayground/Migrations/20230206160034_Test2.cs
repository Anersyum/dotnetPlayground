using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetPlayground.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2023, 2, 6, 17, 0, 33, 794, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2023, 2, 6, 17, 0, 33, 794, DateTimeKind.Local).AddTicks(6784));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2023, 2, 6, 16, 59, 20, 42, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2023, 2, 6, 16, 59, 20, 42, DateTimeKind.Local).AddTicks(8348));
        }
    }
}

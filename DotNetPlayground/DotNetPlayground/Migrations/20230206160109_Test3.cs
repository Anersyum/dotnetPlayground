using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetPlayground.Migrations
{
    /// <inheritdoc />
    public partial class Test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bezeze",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bezeze", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bezeze");

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetPlayground.Migrations
{
    /// <inheritdoc />
    public partial class CarsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tip = table.Column<string>(type: "TEXT", nullable: false),
                    Marka = table.Column<string>(type: "TEXT", nullable: false),
                    DatumKreiranja = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DatumKreiranja", "Marka", "Tip" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 1, 9), "Audi", "Karavan" },
                    { 2, new DateOnly(2023, 1, 9), "Škoda", "Limuzina" },
                    { 3, new DateOnly(2023, 1, 9), "Toyota", "Džip" },
                    { 4, new DateOnly(2023, 1, 9), "VW", "SUV" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}

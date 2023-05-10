using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetPlayground.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
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
                    DatumKreiranja = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mace",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ime = table.Column<string>(type: "TEXT", nullable: true),
                    Vrsta = table.Column<string>(type: "TEXT", nullable: true),
                    Godine = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mace", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Osoblje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoblje", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    FavouriteFood = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opstine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(type: "TEXT", nullable: false),
                    DrzavaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opstine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Opstine_Drzave_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Studenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ime = table.Column<string>(type: "TEXT", nullable: false),
                    Prezime = table.Column<string>(type: "TEXT", nullable: false),
                    BrojIndeksa = table.Column<string>(type: "TEXT", nullable: false),
                    DrzavaRodjenjaId = table.Column<int>(type: "INTEGER", nullable: false),
                    OpstinaRodjenjaId = table.Column<string>(type: "TEXT", nullable: false),
                    OpstinaRodjenjaId1 = table.Column<int>(type: "INTEGER", nullable: false),
                    DatumDodavanja = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProfilnaSlika = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Studenti_Drzave_DrzavaRodjenjaId",
                        column: x => x.DrzavaRodjenjaId,
                        principalTable: "Drzave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Studenti_Opstine_OpstinaRodjenjaId1",
                        column: x => x.OpstinaRodjenjaId1,
                        principalTable: "Opstine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DatumKreiranja", "Marka", "Tip" },
                values: new object[,]
                {
                    { 1, "09.01.2023", "Audi", "Karavan" },
                    { 2, "09.01.2023", "Škoda", "Limuzina" },
                    { 3, "09.01.2023", "Toyota", "Džip" },
                    { 4, "09.01.2023", "VW", "SUV" }
                });

            migrationBuilder.InsertData(
                table: "Osoba",
                columns: new[] { "Id", "DatumKreiranja", "DatumRodjenja", "Email", "Ime", "NajdrazaHrana", "Prezime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 6, 16, 59, 20, 42, DateTimeKind.Local).AddTicks(8304), new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "amor@gmx.com", "Amor", "Krompir", "Osmić" },
                    { 2, new DateTime(2023, 2, 6, 16, 59, 20, 42, DateTimeKind.Local).AddTicks(8348), new DateTime(1995, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "sara@gmx.com", "Sara", "Pizza", "Šahinpašić" },
                    { 3, null, new DateTime(1998, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ines@gmx.com", "Ines", "Špagete", "Osmić" },
                    { 4, null, new DateTime(1994, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "jasko@gmx.com", "Jasko", "Burek", "Kreho" }
                });

            migrationBuilder.InsertData(
                table: "Osoblje",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "admin", "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FavouriteFood", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Krompir", "Amor", "Osmić" },
                    { 2, "Pizza", "Sara", "Šahinpašić" },
                    { 3, "Špagete", "Ines", "Osmić" },
                    { 4, "Burek", "Jasko", "Kreho" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Opstine_DrzavaId",
                table: "Opstine",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_DrzavaRodjenjaId",
                table: "Studenti",
                column: "DrzavaRodjenjaId");

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_OpstinaRodjenjaId1",
                table: "Studenti",
                column: "OpstinaRodjenjaId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Mace");

            migrationBuilder.DropTable(
                name: "Osoba");

            migrationBuilder.DropTable(
                name: "Osoblje");

            migrationBuilder.DropTable(
                name: "Studenti");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Opstine");

            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}

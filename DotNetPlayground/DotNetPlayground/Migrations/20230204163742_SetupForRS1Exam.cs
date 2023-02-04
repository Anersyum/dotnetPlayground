using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetPlayground.Migrations
{
    /// <inheritdoc />
    public partial class SetupForRS1Exam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2023, 2, 4, 17, 37, 42, 170, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2023, 2, 4, 17, 37, 42, 170, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.InsertData(
                table: "Osoblje",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "admin", "Admin" });

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
                name: "Osoblje");

            migrationBuilder.DropTable(
                name: "Studenti");

            migrationBuilder.DropTable(
                name: "Opstine");

            migrationBuilder.DropTable(
                name: "Drzave");

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2023, 1, 18, 14, 57, 41, 591, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Osoba",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2023, 1, 18, 14, 57, 41, 591, DateTimeKind.Local).AddTicks(7707));
        }
    }
}

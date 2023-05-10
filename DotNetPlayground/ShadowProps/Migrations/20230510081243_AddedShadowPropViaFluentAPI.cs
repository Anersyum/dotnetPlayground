using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShadowProps.Migrations
{
    public partial class AddedShadowPropViaFluentAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShadowProperty",
                table: "Students",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShadowProperty",
                table: "Students");
        }
    }
}

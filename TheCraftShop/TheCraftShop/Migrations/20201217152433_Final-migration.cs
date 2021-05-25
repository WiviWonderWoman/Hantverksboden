using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCraftShop.Migrations
{
    public partial class Finalmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCrochet",
                table: "Handicrafts");

            migrationBuilder.DropColumn(
                name: "IsDrawing",
                table: "Handicrafts");

            migrationBuilder.DropColumn(
                name: "IsMacrame",
                table: "Handicrafts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCrochet",
                table: "Handicrafts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDrawing",
                table: "Handicrafts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMacrame",
                table: "Handicrafts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

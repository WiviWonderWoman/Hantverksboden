using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCraftShop.Migrations
{
    public partial class uppdatedCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 1,
                column: "IsCrochet",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 2,
                column: "IsCrochet",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 3,
                column: "IsCrochet",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 4,
                column: "IsCrochet",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 5,
                column: "IsCrochet",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 6,
                column: "IsCrochet",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 7,
                column: "IsCrochet",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 8,
                column: "IsCrochet",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 9,
                column: "IsCrochet",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 10,
                column: "IsMacrame",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 11,
                column: "IsMacrame",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 12,
                column: "IsMacrame",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 13,
                column: "IsMacrame",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 14,
                column: "IsDrawing",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 15,
                column: "IsDrawing",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 16,
                column: "IsDrawing",
                value: true);

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 17,
                column: "IsDrawing",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

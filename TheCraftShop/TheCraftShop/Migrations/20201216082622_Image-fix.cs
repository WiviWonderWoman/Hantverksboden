using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCraftShop.Migrations
{
    public partial class Imagefix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 1,
                column: "Image",
                value: "AngryBirds.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 1,
                column: "Image",
                value: "Angry_birds.jpg");
        }
    }
}

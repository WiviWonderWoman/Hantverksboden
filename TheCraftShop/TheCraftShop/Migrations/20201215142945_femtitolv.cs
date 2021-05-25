using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCraftShop.Migrations
{
    public partial class femtitolv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CraftMethods",
                columns: table => new
                {
                    CraftMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraftMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftMethods", x => x.CraftMethodId);
                });

            migrationBuilder.CreateTable(
                name: "Handicrafts",
                columns: table => new
                {
                    HandicraftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CraftMethodId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Handicrafts", x => x.HandicraftId);
                    table.ForeignKey(
                        name: "FK_Handicrafts_CraftMethods_CraftMethodId",
                        column: x => x.CraftMethodId,
                        principalTable: "CraftMethods",
                        principalColumn: "CraftMethodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Handicrafts_CraftMethodId",
                table: "Handicrafts",
                column: "CraftMethodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Handicrafts");

            migrationBuilder.DropTable(
                name: "CraftMethods");
        }
    }
}

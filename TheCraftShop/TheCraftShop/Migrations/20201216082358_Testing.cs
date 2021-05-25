using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCraftShop.Migrations
{
    public partial class Testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNewItem",
                table: "Handicrafts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "CraftMethods",
                columns: new[] { "CraftMethodId", "CraftMethodName" },
                values: new object[] { 3, "Tecknat" });

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 1,
                column: "Name",
                value: "AngryBirds set");

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 4,
                column: "Image",
                value: "Mus.jpg");

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 7,
                column: "Image",
                value: "Blomma1.jpg");

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 8,
                columns: new[] { "Image", "IsNewItem" },
                values: new object[] { "Blomma2.jpg", true });

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 9,
                column: "Image",
                value: "Studentmössa.jpg");

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 10,
                column: "Image",
                value: "Nyckelring.jpg");

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 11,
                columns: new[] { "Description", "Image" },
                values: new object[] { "Gran med silver pärlor att hänga i halsbandet.", "Hänge.jpg" });

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 13,
                columns: new[] { "Image", "IsNewItem" },
                values: new object[] { "Öronhänge.jpg", true });

            migrationBuilder.InsertData(
                table: "Handicrafts",
                columns: new[] { "HandicraftId", "CraftMethodId", "Description", "Image", "IsNewItem", "Name", "Price" },
                values: new object[,]
                {
                    { 14, 3, "Målning med akvarell, nedgående sol över havet.", "Solnedgång.jpg", false, "Solnedgång", 75 },
                    { 15, 3, "Akryl målning, vågor som slår mot en sandstrand.", "Strand.jpg", false, "Stranden", 75 },
                    { 16, 3, "Blyertsteckning, färglagd med akvarell.", "Träd.jpg", true, "Träd", 75 },
                    { 17, 3, "Teckning i tusch, hur det känns att ha adhd.", "Hjärna.jpg", false, "ADHD-Hjärna", 50 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CraftMethods",
                keyColumn: "CraftMethodId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "IsNewItem",
                table: "Handicrafts");

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 1,
                column: "Name",
                value: "Angry-birds set");

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 4,
                column: "Image",
                value: "Kattleksak_mus1.jpg");

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 7,
                column: "Image",
                value: "Brosch_blomma2.jpg");

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 8,
                column: "Image",
                value: "Brosch_blomma3.jpg");

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 9,
                column: "Image",
                value: "Brosch_studentmössa.jpg");

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 10,
                column: "Image",
                value: "Nyckelring_gran.jpg");

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 11,
                columns: new[] { "Description", "Image" },
                values: new object[] { "Macrame gran med silver pärlor att hänga i halsbandet.", "Halsbandshänge_Gran.jpg" });

            migrationBuilder.UpdateData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 13,
                column: "Image",
                value: "Öronhänge_granar.jpg");
        }
    }
}

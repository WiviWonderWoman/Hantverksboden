using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCraftShop.Migrations
{
    public partial class seededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Handicrafts_CraftMethods_CraftMethodId",
                table: "Handicrafts");

            migrationBuilder.AlterColumn<int>(
                name: "CraftMethodId",
                table: "Handicrafts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "CraftMethods",
                columns: new[] { "CraftMethodId", "CraftMethodName" },
                values: new object[] { 1, "Virkning" });

            migrationBuilder.InsertData(
                table: "CraftMethods",
                columns: new[] { "CraftMethodId", "CraftMethodName" },
                values: new object[] { 2, "Macrame" });

            migrationBuilder.InsertData(
                table: "Handicrafts",
                columns: new[] { "HandicraftId", "CraftMethodId", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Virkat set med 5 st fåglar och 4 st grisar, inspirerade av mobilspelet Angry birds.", "Angry_birds.jpg", "Angry-birds set", 500 },
                    { 2, 1, "Virkat set med 2 st \"Fluffies\", inspirerade av mobilspelet Fluffy fall.", "FluffyDuo.jpg", "Fluffy Duo", 200 },
                    { 3, 1, "Virkat set med 2 st figurer, pokemonsen Jigglypuff & Igglybuff.", "JigglyDuo.jpg", "Pokémon Duett", 100 },
                    { 4, 1, "Virkad kattleksak, en mörkröd mus.", "Kattleksak_mus1.jpg", "Kattleksak", 75 },
                    { 5, 1, "Virkat set med 3 st Pokéball. Vanlig, greateball och ultraball", "Pokeballs.jpg", "Pokéballs", 100 },
                    { 6, 1, "Virkat set med en Pokémon i Pokéball, Pikachu.", "Pika_boll.jpg", "Pika-ball", 150 },
                    { 7, 1, "Virkad brosch, vit anemon.", "Brosch_blomma2.jpg", "Brosch 1", 50 },
                    { 8, 1, "Virkad brosch, röd ros.", "Brosch_blomma3.jpg", "Brosch 2", 50 },
                    { 9, 1, "Virkad brosch, studentmössa.", "Brosch_studentmössa.jpg", "Brosch 3", 50 },
                    { 10, 2, "Macrame nyckelring, gran.", "Nyckelring_gran.jpg", "Nyckelring", 50 },
                    { 11, 2, "Macrame gran med silver pärlor att hänga i halsbandet.", "Halsbandshänge_Gran.jpg", "Hänge", 50 },
                    { 12, 2, "Macrame armband.", "Armband.jpg", "Armband", 75 },
                    { 13, 2, "Macrame öronhänge, gröna granar.", "Öronhänge_granar.jpg", "Öronhängen", 75 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Handicrafts_CraftMethods_CraftMethodId",
                table: "Handicrafts",
                column: "CraftMethodId",
                principalTable: "CraftMethods",
                principalColumn: "CraftMethodId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Handicrafts_CraftMethods_CraftMethodId",
                table: "Handicrafts");

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Handicrafts",
                keyColumn: "HandicraftId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CraftMethods",
                keyColumn: "CraftMethodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CraftMethods",
                keyColumn: "CraftMethodId",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "CraftMethodId",
                table: "Handicrafts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Handicrafts_CraftMethods_CraftMethodId",
                table: "Handicrafts",
                column: "CraftMethodId",
                principalTable: "CraftMethods",
                principalColumn: "CraftMethodId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

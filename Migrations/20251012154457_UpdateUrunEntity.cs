using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUrunEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Urunler",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Anasayfa",
                table: "Urunler",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "Urunler",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Aciklama", "Active", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.", true, true, "1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Aciklama", "Active", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.", false, false, "2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.", true, "3.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Aciklama", "Active", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.", true, false, "4.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.", true, "5.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Aciklama", "Active", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.", false, true, "6.jpeg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "Aciklama", "Active", "Anasayfa", "Fiyat", "Resim", "UrunAd" },
                values: new object[,]
                {
                    { 7, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.", true, true, 90000.0, "7.jpeg", "Apple Watch 13" },
                    { 8, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.", true, true, 100000.0, "8.jpeg", "Apple Watch 14" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "Anasayfa",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "Resim",
                table: "Urunler");

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6,
                column: "Active",
                value: true);
        }
    }
}

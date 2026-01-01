using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UrunAd = table.Column<string>(type: "TEXT", nullable: true),
                    Fiyat = table.Column<double>(type: "REAL", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "Active", "Fiyat", "UrunAd" },
                values: new object[,]
                {
                    { 1, false, 30000.0, "Apple Watch 7" },
                    { 2, true, 40000.0, "Apple Watch 8" },
                    { 3, true, 50000.0, "Apple Watch 9" },
                    { 4, false, 60000.0, "Apple Watch 10" },
                    { 5, true, 70000.0, "Apple Watch 11" },
                    { 6, true, 80000.0, "Apple Watch 12" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urunler");
        }
    }
}

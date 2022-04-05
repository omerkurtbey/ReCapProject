using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Araba Markaları",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Araba Markaları", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Renkler",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renkler", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ModelYear = table.Column<int>(type: "int", nullable: false),
                    DailyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arabalar_Araba Markaları_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Araba Markaları",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marka Renk",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marka Renk", x => new { x.ColorId, x.BrandId });
                    table.ForeignKey(
                        name: "FK_Marka Renk_Araba Markaları_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Araba Markaları",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Marka Renk_Renkler_ColorId", 
                        column: x => x.ColorId,
                        principalTable: "Renkler",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Araba Renk",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Araba Renk", x => new { x.ColorId, x.CarId });
                    table.ForeignKey(
                        name: "FK_Araba Renk_Arabalar_CarId",
                        column: x => x.CarId,
                        principalTable: "Arabalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Araba Renk_Renkler_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Renkler",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Araba Markaları",
                columns: new[] { "BrandId", "BrandName" },
                values: new object[,]
                {
                    { 1, "Mazda" },
                    { 2, "Ford" },
                    { 3, "Opel" },
                    { 4, "Mercedes" },
                    { 5, "Audi" },
                    { 6, "Renault" },
                    { 7, "Citroen" },
                    { 8, "Hyundai" }
                });

            migrationBuilder.InsertData(
                table: "Renkler",
                columns: new[] { "ColorId", "ColorName" },
                values: new object[,]
                {
                    { 1, "Siyah" },
                    { 2, "Beyaz" },
                    { 3, "Gri" },
                    { 4, "Kırmızı" }
                });

            migrationBuilder.InsertData(
                table: "Arabalar",
                columns: new[] { "Id", "BrandId", "ColorId", "DailyPrice", "Description", "ModelYear" },
                values: new object[,]
                {
                    { 1, 1, 1, 1000m, "SUV", 2011 },
                    { 2, 2, 2, 5200m, "Binek", 2015 },
                    { 3, 2, 4, 6200m, "Binek", 2016 },
                    { 4, 3, 1, 7200m, "Sport", 2018 },
                    { 5, 4, 3, 5200m, "Cabrio", 2021 },
                    { 6, 5, 1, 3000m, "SUV", 2011 },
                    { 7, 6, 2, 6200m, "Binek", 2015 },
                    { 8, 7, 4, 9200m, "Binek", 2016 },
                    { 9, 8, 1, 2200m, "Sport", 2018 },
                    { 10, 8, 3, 3200m, "Cabrio", 2021 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Araba Renk_CarId",
                table: "Araba Renk",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_BrandId",
                table: "Arabalar",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Marka Renk_BrandId",
                table: "Marka Renk",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Araba Renk");

            migrationBuilder.DropTable(
                name: "Marka Renk");

            migrationBuilder.DropTable(
                name: "Arabalar");

            migrationBuilder.DropTable(
                name: "Renkler");

            migrationBuilder.DropTable(
                name: "Araba Markaları");
        }
    }
}

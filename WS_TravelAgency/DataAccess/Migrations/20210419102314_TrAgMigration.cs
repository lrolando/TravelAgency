using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class TrAgMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientTypes",
                columns: table => new
                {
                    ClientTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTypes", x => x.ClientTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PackageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namepack = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PackageID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Type = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Category = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", unicode: false, maxLength: 15, nullable: false),
                    IDPack = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_Package",
                        column: x => x.IDPack,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ClientTypes",
                columns: new[] { "ClientTypeId", "Description" },
                values: new object[,]
                {
                    { 1, "Individual" },
                    { 2, "Corporate" }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "PackageID", "Namepack" },
                values: new object[,]
                {
                    { 1, "Cordoba" },
                    { 2, "San Juan" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "Category", "Description", "IDPack", "Price", "Type" },
                values: new object[,]
                {
                    { 1, null, "Hotel Sol", 1, 350m, "Hotel" },
                    { 2, "2", "VW Vento", 1, 120m, "RentCar" },
                    { 3, null, "B747", 1, 380m, "Ticket" },
                    { 4, null, "A380", 2, 120m, "Ticket" },
                    { 5, "3", "Renault", 2, 220m, "RentCar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_IDPack",
                table: "Product",
                column: "IDPack");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientTypes");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Packages");
        }
    }
}

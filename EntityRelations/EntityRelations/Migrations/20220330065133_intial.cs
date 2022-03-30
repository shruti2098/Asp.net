using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityRelations.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModelInfo",
                columns: table => new
                {
                    ModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelInfo", x => x.ModelId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProdId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProdId);
                });

            migrationBuilder.CreateTable(
                name: "ProductDes",
                columns: table => new
                {
                    ProductDesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductDetails = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDes", x => x.ProductDesId);
                });

            migrationBuilder.CreateTable(
                name: "ModelInfoProduct",
                columns: table => new
                {
                    ModelInfosModelId = table.Column<int>(type: "int", nullable: false),
                    ProductsProdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelInfoProduct", x => new { x.ModelInfosModelId, x.ProductsProdId });
                    table.ForeignKey(
                        name: "FK_ModelInfoProduct_ModelInfo_ModelInfosModelId",
                        column: x => x.ModelInfosModelId,
                        principalTable: "ModelInfo",
                        principalColumn: "ModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelInfoProduct_Product_ProductsProdId",
                        column: x => x.ProductsProdId,
                        principalTable: "Product",
                        principalColumn: "ProdId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModelInfoProduct_ProductsProdId",
                table: "ModelInfoProduct",
                column: "ProductsProdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelInfoProduct");

            migrationBuilder.DropTable(
                name: "ProductDes");

            migrationBuilder.DropTable(
                name: "ModelInfo");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}

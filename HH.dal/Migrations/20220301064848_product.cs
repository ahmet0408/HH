using Microsoft.EntityFrameworkCore.Migrations;

namespace HH.dal.Migrations
{
    public partial class product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Option_Product_ProductId",
                table: "Option");

            migrationBuilder.DropIndex(
                name: "IX_Option_ProductId",
                table: "Option");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Option");

            migrationBuilder.CreateTable(
                name: "ProductOption",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    OptionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOption", x => new { x.ProductId, x.OptionId });
                    table.ForeignKey(
                        name: "FK_ProductOption_Option_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Option",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOption_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductOption_OptionId",
                table: "ProductOption",
                column: "OptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductOption");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Option",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Option_ProductId",
                table: "Option",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Option_Product_ProductId",
                table: "Option",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

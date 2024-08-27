using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAnswer.Migrations
{
    /// <inheritdoc />
    public partial class AddPurchaseInvoiceWithDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_PurchaseInvoices_PurchaseInvoiceid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PurchaseInvoiceid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PurchaseInvoiceid",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PurchaseInvoices",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseInvoiceId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceProducts_PurchaseInvoices_PurchaseInvoiceId",
                        column: x => x.PurchaseInvoiceId,
                        principalTable: "PurchaseInvoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceProducts_ProductId",
                table: "PurchaseInvoiceProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceProducts_PurchaseInvoiceId",
                table: "PurchaseInvoiceProducts",
                column: "PurchaseInvoiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseInvoiceProducts");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PurchaseInvoices",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseInvoiceid",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseInvoiceid",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseInvoiceid",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "PurchaseInvoiceid",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Products_PurchaseInvoiceid",
                table: "Products",
                column: "PurchaseInvoiceid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PurchaseInvoices_PurchaseInvoiceid",
                table: "Products",
                column: "PurchaseInvoiceid",
                principalTable: "PurchaseInvoices",
                principalColumn: "id");
        }
    }
}

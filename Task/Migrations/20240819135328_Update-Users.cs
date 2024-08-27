using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAnswer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseInvoiceid",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PurchaseInvoices",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoices", x => x.id);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoices_CustomerId",
                table: "PurchaseInvoices",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PurchaseInvoices_PurchaseInvoiceid",
                table: "Products",
                column: "PurchaseInvoiceid",
                principalTable: "PurchaseInvoices",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_PurchaseInvoices_PurchaseInvoiceid",
                table: "Products");

            migrationBuilder.DropTable(
                name: "PurchaseInvoices");

            migrationBuilder.DropIndex(
                name: "IX_Products_PurchaseInvoiceid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PurchaseInvoiceid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Customers");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }
    }
}

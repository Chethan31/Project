using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellPhonesStore.DataAccess.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomOrders_Customers_CustomerId",
                table: "CustomOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdereredPhones_CustomOrders_CustomerOrderOrderId",
                table: "OrdereredPhones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomOrders",
                table: "CustomOrders");

            migrationBuilder.RenameTable(
                name: "CustomOrders",
                newName: "CustomerOrders");

            migrationBuilder.RenameIndex(
                name: "IX_CustomOrders_CustomerId",
                table: "CustomerOrders",
                newName: "IX_CustomerOrders_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerOrders",
                table: "CustomerOrders",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerOrders_Customers_CustomerId",
                table: "CustomerOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdereredPhones_CustomerOrders_CustomerOrderOrderId",
                table: "OrdereredPhones",
                column: "CustomerOrderOrderId",
                principalTable: "CustomerOrders",
                principalColumn: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerOrders_Customers_CustomerId",
                table: "CustomerOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdereredPhones_CustomerOrders_CustomerOrderOrderId",
                table: "OrdereredPhones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerOrders",
                table: "CustomerOrders");

            migrationBuilder.RenameTable(
                name: "CustomerOrders",
                newName: "CustomOrders");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerOrders_CustomerId",
                table: "CustomOrders",
                newName: "IX_CustomOrders_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomOrders",
                table: "CustomOrders",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomOrders_Customers_CustomerId",
                table: "CustomOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdereredPhones_CustomOrders_CustomerOrderOrderId",
                table: "OrdereredPhones",
                column: "CustomerOrderOrderId",
                principalTable: "CustomOrders",
                principalColumn: "OrderId");
        }
    }
}

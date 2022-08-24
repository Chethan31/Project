using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellPhonesStore.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    PhoneId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.PhoneId);
                });

            migrationBuilder.CreateTable(
                name: "CustomOrders",
                columns: table => new
                {
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    OrderTotal = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomOrders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_CustomOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "OrdereredPhones",
                columns: table => new
                {
                    OrderedPhoneId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderedPhonePhoneId = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    CustomerOrderOrderId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdereredPhones", x => x.OrderedPhoneId);
                    table.ForeignKey(
                        name: "FK_OrdereredPhones_CustomOrders_CustomerOrderOrderId",
                        column: x => x.CustomerOrderOrderId,
                        principalTable: "CustomOrders",
                        principalColumn: "OrderId");
                    table.ForeignKey(
                        name: "FK_OrdereredPhones_Phones_OrderedPhonePhoneId",
                        column: x => x.OrderedPhonePhoneId,
                        principalTable: "Phones",
                        principalColumn: "PhoneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomOrders_CustomerId",
                table: "CustomOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdereredPhones_CustomerOrderOrderId",
                table: "OrdereredPhones",
                column: "CustomerOrderOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdereredPhones_OrderedPhonePhoneId",
                table: "OrdereredPhones",
                column: "OrderedPhonePhoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdereredPhones");

            migrationBuilder.DropTable(
                name: "CustomOrders");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}

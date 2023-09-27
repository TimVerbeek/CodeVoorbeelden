using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BroodnodigAPI.Migrations
{
    /// <inheritdoc />
    public partial class orderregels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breads_Orders_OrderId",
                table: "Breads");

            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Orders_OrderId",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Toppings_OrderId",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Breads_OrderId",
                table: "Breads");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Breads");

            migrationBuilder.CreateTable(
                name: "OrderBreads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BreadId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderBreads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderBreads_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderToppings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ToppingId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderToppings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderToppings_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderBreads_OrderId",
                table: "OrderBreads",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToppings_OrderId",
                table: "OrderToppings",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderBreads");

            migrationBuilder.DropTable(
                name: "OrderToppings");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Toppings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Breads",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_OrderId",
                table: "Toppings",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Breads_OrderId",
                table: "Breads",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Breads_Orders_OrderId",
                table: "Breads",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Toppings_Orders_OrderId",
                table: "Toppings",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}

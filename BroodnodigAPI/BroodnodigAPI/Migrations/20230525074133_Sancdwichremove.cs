using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BroodnodigAPI.Migrations
{
    /// <inheritdoc />
    public partial class Sancdwichremove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sandwich");

            migrationBuilder.AddColumn<string>(
                name: "Img_Url",
                table: "Toppings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Toppings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img_Url",
                table: "DailySnacks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Img_Url",
                table: "Breads",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Img_Url",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "Img_Url",
                table: "DailySnacks");

            migrationBuilder.DropColumn(
                name: "Img_Url",
                table: "Breads");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Breads");

            migrationBuilder.CreateTable(
                name: "Sandwich",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    BreadId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ToppingId = table.Column<Guid>(type: "TEXT", nullable: true),
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sandwich", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sandwich_Breads_BreadId",
                        column: x => x.BreadId,
                        principalTable: "Breads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sandwich_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sandwich_Toppings_ToppingId",
                        column: x => x.ToppingId,
                        principalTable: "Toppings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sandwich_BreadId",
                table: "Sandwich",
                column: "BreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Sandwich_OrderId",
                table: "Sandwich",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Sandwich_ToppingId",
                table: "Sandwich",
                column: "ToppingId");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BroodnodigAPI.Migrations
{
    /// <inheritdoc />
    public partial class breadtypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Sandwich_SandwichId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Sandwich_Toppings_ToppingId",
                table: "Sandwich");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SandwichId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SandwichId",
                table: "Orders");

            migrationBuilder.AlterColumn<Guid>(
                name: "ToppingId",
                table: "Sandwich",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Sandwich",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Breads",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Sandwich_OrderId",
                table: "Sandwich",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sandwich_Orders_OrderId",
                table: "Sandwich",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sandwich_Toppings_ToppingId",
                table: "Sandwich",
                column: "ToppingId",
                principalTable: "Toppings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sandwich_Orders_OrderId",
                table: "Sandwich");

            migrationBuilder.DropForeignKey(
                name: "FK_Sandwich_Toppings_ToppingId",
                table: "Sandwich");

            migrationBuilder.DropIndex(
                name: "IX_Sandwich_OrderId",
                table: "Sandwich");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Sandwich");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Breads");

            migrationBuilder.AlterColumn<Guid>(
                name: "ToppingId",
                table: "Sandwich",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SandwichId",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SandwichId",
                table: "Orders",
                column: "SandwichId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Sandwich_SandwichId",
                table: "Orders",
                column: "SandwichId",
                principalTable: "Sandwich",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sandwich_Toppings_ToppingId",
                table: "Sandwich",
                column: "ToppingId",
                principalTable: "Toppings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

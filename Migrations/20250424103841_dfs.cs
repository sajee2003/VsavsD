using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventBookingManagementSystem_Backend.Migrations
{
    /// <inheritdoc />
    public partial class dfs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Item_Categories_item_CategoryItemCategoryId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_item_CategoryItemCategoryId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "item_CategoryItemCategoryId",
                table: "Items");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Item_Categories_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId",
                principalTable: "Item_Categories",
                principalColumn: "ItemCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Item_Categories_ItemCategoryId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemCategoryId",
                table: "Items");

            migrationBuilder.AddColumn<Guid>(
                name: "item_CategoryItemCategoryId",
                table: "Items",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Items_item_CategoryItemCategoryId",
                table: "Items",
                column: "item_CategoryItemCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Item_Categories_item_CategoryItemCategoryId",
                table: "Items",
                column: "item_CategoryItemCategoryId",
                principalTable: "Item_Categories",
                principalColumn: "ItemCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

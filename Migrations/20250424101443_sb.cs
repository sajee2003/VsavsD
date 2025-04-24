using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventBookingManagementSystem_Backend.Migrations
{
    /// <inheritdoc />
    public partial class sb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Item_Item_ItemId",
                table: "Asset_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Package_Item_Item_ItemId",
                table: "Booking_Package_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_Categories_item_CategoryItemCategoryId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Price_Item_ItemId",
                table: "Item_Price");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_Item_Item_ItemId",
                table: "Package_Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_Item_item_CategoryItemCategoryId",
                table: "Items",
                newName: "IX_Items_item_CategoryItemCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Item_Items_ItemId",
                table: "Asset_Item",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Package_Item_Items_ItemId",
                table: "Booking_Package_Item",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Price_Items_ItemId",
                table: "Item_Price",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Item_Categories_item_CategoryItemCategoryId",
                table: "Items",
                column: "item_CategoryItemCategoryId",
                principalTable: "Item_Categories",
                principalColumn: "ItemCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_Item_Items_ItemId",
                table: "Package_Item",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Item_Items_ItemId",
                table: "Asset_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Package_Item_Items_ItemId",
                table: "Booking_Package_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Price_Items_ItemId",
                table: "Item_Price");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Item_Categories_item_CategoryItemCategoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_Item_Items_ItemId",
                table: "Package_Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameIndex(
                name: "IX_Items_item_CategoryItemCategoryId",
                table: "Item",
                newName: "IX_Item_item_CategoryItemCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Item_Item_ItemId",
                table: "Asset_Item",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Package_Item_Item_ItemId",
                table: "Booking_Package_Item",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_Categories_item_CategoryItemCategoryId",
                table: "Item",
                column: "item_CategoryItemCategoryId",
                principalTable: "Item_Categories",
                principalColumn: "ItemCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Price_Item_ItemId",
                table: "Item_Price",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_Item_Item_ItemId",
                table: "Package_Item",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventBookingManagementSystem_Backend.Migrations
{
    /// <inheritdoc />
    public partial class VAZ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssetStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.AssetId);
                });

            migrationBuilder.CreateTable(
                name: "Item_Categories",
                columns: table => new
                {
                    ItemCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Categories", x => x.ItemCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.PackageId);
                });

            migrationBuilder.CreateTable(
                name: "Booking_Asset",
                columns: table => new
                {
                    BookingAssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking_Asset", x => x.BookingAssetId);
                    table.ForeignKey(
                        name: "FK_Booking_Asset_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "AssetId");
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    item_CategoryItemCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Item_Item_Categories_item_CategoryItemCategoryId",
                        column: x => x.item_CategoryItemCategoryId,
                        principalTable: "Item_Categories",
                        principalColumn: "ItemCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asset_Item",
                columns: table => new
                {
                    AssetItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset_Item", x => x.AssetItemId);
                    table.ForeignKey(
                        name: "FK_Asset_Item_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asset_Item_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking_Package_Item",
                columns: table => new
                {
                    BookingPackageItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking_Package_Item", x => x.BookingPackageItemId);
                    table.ForeignKey(
                        name: "FK_Booking_Package_Item_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "Item_Price",
                columns: table => new
                {
                    ItemPriceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    base_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    asset_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    price_type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Price", x => x.ItemPriceID);
                    table.ForeignKey(
                        name: "FK_Item_Price_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_Price_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Package_Item",
                columns: table => new
                {
                    PackageItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    item = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package_Item", x => x.PackageItemId);
                    table.ForeignKey(
                        name: "FK_Package_Item_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Package_Item_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Package_Item_Package_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Package",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Item_AssetId",
                table: "Asset_Item",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Item_ItemId",
                table: "Asset_Item",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Asset_AssetId",
                table: "Booking_Asset",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Package_Item_ItemId",
                table: "Booking_Package_Item",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_item_CategoryItemCategoryId",
                table: "Item",
                column: "item_CategoryItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_Price_AssetId",
                table: "Item_Price",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_Price_ItemId",
                table: "Item_Price",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_Item_AssetId",
                table: "Package_Item",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_Item_ItemId",
                table: "Package_Item",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_Item_PackageId",
                table: "Package_Item",
                column: "PackageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asset_Item");

            migrationBuilder.DropTable(
                name: "Booking_Asset");

            migrationBuilder.DropTable(
                name: "Booking_Package_Item");

            migrationBuilder.DropTable(
                name: "Item_Price");

            migrationBuilder.DropTable(
                name: "Package_Item");

            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "Item_Categories");
        }
    }
}

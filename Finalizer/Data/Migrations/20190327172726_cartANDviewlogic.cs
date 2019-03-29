using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finalizer.Data.Migrations
{
    public partial class cartANDviewlogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColor_Products_ProductID",
                table: "ProductColor");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Products_ProductID",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Products_ProductID",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductColor",
                table: "ProductColor");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "ProductImage",
                newName: "ProductImages");

            migrationBuilder.RenameTable(
                name: "ProductColor",
                newName: "ProductColors");

            migrationBuilder.RenameIndex(
                name: "IX_Review_ProductID",
                table: "Reviews",
                newName: "IX_Reviews_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_ProductID",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColor_ProductID",
                table: "ProductColors",
                newName: "IX_ProductColors_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CookieIdentifier = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    ProductColorID = table.Column<int>(nullable: true),
                    ProductPrice = table.Column<decimal>(nullable: false),
                    CartID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartID",
                        column: x => x.CartID,
                        principalTable: "Carts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_ProductColors_ProductColorID",
                        column: x => x.ProductColorID,
                        principalTable: "ProductColors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartID",
                table: "CartItems",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductColorID",
                table: "CartItems",
                column: "ProductColorID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductID",
                table: "CartItems",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColors_Products_ProductID",
                table: "ProductColors",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductID",
                table: "ProductImages",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductID",
                table: "Reviews",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColors_Products_ProductID",
                table: "ProductColors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductID",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductID",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "ProductImage");

            migrationBuilder.RenameTable(
                name: "ProductColors",
                newName: "ProductColor");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_ProductID",
                table: "Review",
                newName: "IX_Review_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductID",
                table: "ProductImage",
                newName: "IX_ProductImage_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColors_ProductID",
                table: "ProductColor",
                newName: "IX_ProductColor_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductColor",
                table: "ProductColor",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColor_Products_ProductID",
                table: "ProductColor",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Products_ProductID",
                table: "ProductImage",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Products_ProductID",
                table: "Review",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

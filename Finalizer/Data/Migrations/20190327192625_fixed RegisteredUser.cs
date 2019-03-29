using Microsoft.EntityFrameworkCore.Migrations;

namespace Finalizer.Data.Migrations
{
    public partial class fixedRegisteredUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegisteredUserId",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RegisteredUserId",
                table: "Reviews",
                column: "RegisteredUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CartID",
                table: "AspNetUsers",
                column: "CartID",
                unique: true,
                filter: "[CartID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Carts_CartID",
                table: "AspNetUsers",
                column: "CartID",
                principalTable: "Carts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_RegisteredUserId",
                table: "Reviews",
                column: "RegisteredUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Carts_CartID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_RegisteredUserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_RegisteredUserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CartID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RegisteredUserId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "CartID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}

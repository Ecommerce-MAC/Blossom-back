using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class fgh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_IdBrand",
                table: "Products",
                column: "IdBrand");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brand_IdBrand",
                table: "Products",
                column: "IdBrand",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brand_IdBrand",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_IdBrand",
                table: "Products");
        }
    }
}

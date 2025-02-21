using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Jeffries.Migrations
{
    /// <inheritdoc />
    public partial class FixCategoryRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Movies");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryID",
                table: "Movies",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_CategoryID",
                table: "Movies",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_CategoryID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CategoryID",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Movies",
                type: "TEXT",
                nullable: true);
        }
    }
}

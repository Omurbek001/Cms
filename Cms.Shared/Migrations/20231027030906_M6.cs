using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Shared.Migrations
{
    /// <inheritdoc />
    public partial class M6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Units",
                table: "Commodity",
                newName: "Price");

            migrationBuilder.AddColumn<long>(
                name: "ImageId",
                table: "Commodity",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemCount",
                table: "Commodity",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_ImageId",
                table: "Commodity",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_Image_ImageId",
                table: "Commodity",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commodity_Image_ImageId",
                table: "Commodity");

            migrationBuilder.DropIndex(
                name: "IX_Commodity_ImageId",
                table: "Commodity");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Commodity");

            migrationBuilder.DropColumn(
                name: "ItemCount",
                table: "Commodity");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Commodity",
                newName: "Units");
        }
    }
}

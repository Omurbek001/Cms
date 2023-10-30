using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Shared.Migrations
{
    /// <inheritdoc />
    public partial class M7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartegoryId",
                table: "CommodityCategory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CartegoryId",
                table: "CommodityCategory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}

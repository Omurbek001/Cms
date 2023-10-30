using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Shared.Migrations
{
    /// <inheritdoc />
    public partial class M4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Order",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Caption",
                table: "Order",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Order",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Order",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Order",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Order",
                newName: "Caption");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Shared.Migrations
{
    /// <inheritdoc />
    public partial class M2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ObjectName",
                table: "UserProfiles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObjectName",
                table: "University",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObjectName",
                table: "Order",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ObjectName",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "ObjectName",
                table: "University");

            migrationBuilder.DropColumn(
                name: "ObjectName",
                table: "Order");
        }
    }
}

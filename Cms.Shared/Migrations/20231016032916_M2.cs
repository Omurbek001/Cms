using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cms.Shared.Migrations
{
    /// <inheritdoc />
    public partial class M2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_CommodityCategory_CommodityId",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_CommodityCategory_CommodityId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "Caption",
                table: "CommodityCategory");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CommodityCategory");

            migrationBuilder.DropColumn(
                name: "Units",
                table: "CommodityCategory");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "CommodityCategory");

            migrationBuilder.DropColumn(
                name: "WeightUnit",
                table: "CommodityCategory");

            migrationBuilder.AddColumn<long>(
                name: "CartegoryId",
                table: "CommodityCategory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CategoryId",
                table: "CommodityCategory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CommodityId",
                table: "CommodityCategory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cart",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<Guid>(
                name: "Uid",
                table: "Cart",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Commodity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Caption = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    WeightUnit = table.Column<string>(type: "text", nullable: true),
                    Units = table.Column<int>(type: "integer", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: true),
                    UpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ObjectName = table.Column<string>(type: "text", nullable: true),
                    ClassId = table.Column<int>(type: "integer", nullable: false),
                    StateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodity", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommodityCategory_CategoryId",
                table: "CommodityCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityCategory_CommodityId",
                table: "CommodityCategory",
                column: "CommodityId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Commodity_CommodityId",
                table: "CartItem",
                column: "CommodityId",
                principalTable: "Commodity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommodityCategory_Category_CategoryId",
                table: "CommodityCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommodityCategory_Commodity_CommodityId",
                table: "CommodityCategory",
                column: "CommodityId",
                principalTable: "Commodity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Commodity_CommodityId",
                table: "OrderItem",
                column: "CommodityId",
                principalTable: "Commodity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Commodity_CommodityId",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CommodityCategory_Category_CategoryId",
                table: "CommodityCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_CommodityCategory_Commodity_CommodityId",
                table: "CommodityCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Commodity_CommodityId",
                table: "OrderItem");

            migrationBuilder.DropTable(
                name: "Commodity");

            migrationBuilder.DropIndex(
                name: "IX_CommodityCategory_CategoryId",
                table: "CommodityCategory");

            migrationBuilder.DropIndex(
                name: "IX_CommodityCategory_CommodityId",
                table: "CommodityCategory");

            migrationBuilder.DropColumn(
                name: "CartegoryId",
                table: "CommodityCategory");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CommodityCategory");

            migrationBuilder.DropColumn(
                name: "CommodityId",
                table: "CommodityCategory");

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Cart");

            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "CommodityCategory",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CommodityCategory",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Units",
                table: "CommodityCategory",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "CommodityCategory",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WeightUnit",
                table: "CommodityCategory",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cart",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_CommodityCategory_CommodityId",
                table: "CartItem",
                column: "CommodityId",
                principalTable: "CommodityCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_CommodityCategory_CommodityId",
                table: "OrderItem",
                column: "CommodityId",
                principalTable: "CommodityCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace esewa_market.Migrations
{
    /// <inheritdoc />
    public partial class Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "products");

            migrationBuilder.AddColumn<string>(
                name: "Colors",
                table: "products",
                type: "jsonb",
                nullable: false,
                defaultValue: "{}");

            migrationBuilder.AddColumn<List<string>>(
                name: "ImageUrls",
                table: "products",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddColumn<int[]>(
                name: "Sizes",
                table: "products",
                type: "integer[]",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Colors",
                table: "products");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Sizes",
                table: "products");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "products",
                type: "text",
                nullable: true);
        }
    }
}

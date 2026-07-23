using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace esewa_market.Migrations
{
    /// <inheritdoc />
    public partial class changedsizestojson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string[]>(
                name: "Sizes",
                table: "products",
                type: "text[]",
                nullable: false,
                defaultValue: new string[0],
                oldClrType: typeof(int[]),
                oldType: "integer[]",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int[]>(
                name: "Sizes",
                table: "products",
                type: "integer[]",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]");
        }
    }
}

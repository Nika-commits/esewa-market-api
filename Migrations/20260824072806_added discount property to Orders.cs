using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace esewa_market.Migrations
{
    /// <inheritdoc />
    public partial class addeddiscountpropertytoOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "orders");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace esewa_market.Migrations
{
    /// <inheritdoc />
    public partial class typofix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VechlceNumber",
                table: "orders",
                newName: "VehicleNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VehicleNumber",
                table: "orders",
                newName: "VechlceNumber");
        }
    }
}

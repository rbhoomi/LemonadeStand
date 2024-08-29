using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LemonadeStand.Migrations
{
    /// <inheritdoc />
    public partial class updatedTotalAmountType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Order",
                type: "decimal(22,5)",
                precision: 22,
                scale: 5,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalAmount",
                table: "Order",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(22,5)",
                oldPrecision: 22,
                oldScale: 5);
        }
    }
}

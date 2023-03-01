using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanduJewel.Migrations
{
    /// <inheritdoc />
    public partial class fifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_PaymentP_ID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PaymentP_ID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymentP_ID",
                table: "Orders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentP_ID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentP_ID",
                table: "Orders",
                column: "PaymentP_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_PaymentP_ID",
                table: "Orders",
                column: "PaymentP_ID",
                principalTable: "Payments",
                principalColumn: "P_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

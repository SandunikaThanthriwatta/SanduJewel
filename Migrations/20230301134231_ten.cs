using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanduJewel.Migrations
{
    /// <inheritdoc />
    public partial class ten : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerC_NIC",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_PaymentP_ID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerC_NIC",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "C_ID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerC_NIC",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "P_ID",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentP_ID",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_PaymentP_ID",
                table: "Orders",
                column: "PaymentP_ID",
                principalTable: "Payments",
                principalColumn: "P_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_PaymentP_ID",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentP_ID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "C_ID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerC_NIC",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "P_ID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerC_NIC",
                table: "Orders",
                column: "CustomerC_NIC");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerC_NIC",
                table: "Orders",
                column: "CustomerC_NIC",
                principalTable: "Customers",
                principalColumn: "C_NIC",
                onDelete: ReferentialAction.Cascade);

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

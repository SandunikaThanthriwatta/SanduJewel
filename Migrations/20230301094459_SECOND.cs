using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanduJewel.Migrations
{
    /// <inheritdoc />
    public partial class SECOND : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "P_Id",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentP_ID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "C_ID",
                table: "Jewelleries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerC_NIC",
                table: "Jewelleries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "O_ID",
                table: "Jewelleries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OwnerO_Name",
                table: "Jewelleries",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerC_NIC",
                table: "Orders",
                column: "CustomerC_NIC");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentP_ID",
                table: "Orders",
                column: "PaymentP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Jewelleries_CustomerC_NIC",
                table: "Jewelleries",
                column: "CustomerC_NIC");

            migrationBuilder.CreateIndex(
                name: "IX_Jewelleries_OwnerO_Name",
                table: "Jewelleries",
                column: "OwnerO_Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Jewelleries_Customers_CustomerC_NIC",
                table: "Jewelleries",
                column: "CustomerC_NIC",
                principalTable: "Customers",
                principalColumn: "C_NIC",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jewelleries_Owners_OwnerO_Name",
                table: "Jewelleries",
                column: "OwnerO_Name",
                principalTable: "Owners",
                principalColumn: "O_Name",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jewelleries_Customers_CustomerC_NIC",
                table: "Jewelleries");

            migrationBuilder.DropForeignKey(
                name: "FK_Jewelleries_Owners_OwnerO_Name",
                table: "Jewelleries");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerC_NIC",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_PaymentP_ID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerC_NIC",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PaymentP_ID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Jewelleries_CustomerC_NIC",
                table: "Jewelleries");

            migrationBuilder.DropIndex(
                name: "IX_Jewelleries_OwnerO_Name",
                table: "Jewelleries");

            migrationBuilder.DropColumn(
                name: "C_ID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerC_NIC",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "P_Id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymentP_ID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "C_ID",
                table: "Jewelleries");

            migrationBuilder.DropColumn(
                name: "CustomerC_NIC",
                table: "Jewelleries");

            migrationBuilder.DropColumn(
                name: "O_ID",
                table: "Jewelleries");

            migrationBuilder.DropColumn(
                name: "OwnerO_Name",
                table: "Jewelleries");
        }
    }
}

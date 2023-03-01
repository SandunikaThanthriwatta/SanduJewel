using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanduJewel.Migrations
{
    /// <inheritdoc />
    public partial class nine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "O_ID",
                table: "Jewelleries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "O_ID",
                table: "Jewelleries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

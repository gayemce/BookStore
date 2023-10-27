using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreServer.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderStatues");

            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "OrderStatues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "OrderStatues");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderStatues",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop1.Migrations
{
    public partial class new_item : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "DBOrderDetail");

            migrationBuilder.DropColumn(
                name: "available",
                table: "DBItem");

            migrationBuilder.DropColumn(
                name: "category_id",
                table: "DBItem");

            migrationBuilder.DropColumn(
                name: "price",
                table: "DBItem");

            migrationBuilder.DropColumn(
                name: "price",
                table: "DBCartItem");

            migrationBuilder.AddColumn<string>(
                name: "adress",
                table: "DBOrderDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "adress",
                table: "DBItem",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "latitude",
                table: "DBItem",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "longitude",
                table: "DBItem",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "adress",
                table: "DBCartItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "adress",
                table: "DBOrderDetail");

            migrationBuilder.DropColumn(
                name: "adress",
                table: "DBItem");

            migrationBuilder.DropColumn(
                name: "latitude",
                table: "DBItem");

            migrationBuilder.DropColumn(
                name: "longitude",
                table: "DBItem");

            migrationBuilder.DropColumn(
                name: "adress",
                table: "DBCartItem");

            migrationBuilder.AddColumn<long>(
                name: "price",
                table: "DBOrderDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "available",
                table: "DBItem",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "category_id",
                table: "DBItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "DBItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "DBCartItem",
                nullable: false,
                defaultValue: 0);
        }
    }
}

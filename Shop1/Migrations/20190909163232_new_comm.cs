using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop1.Migrations
{
    public partial class new_comm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCountry",
                table: "Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserCountry",
                table: "Comments");
        }
    }
}

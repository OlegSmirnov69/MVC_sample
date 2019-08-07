using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DBCategory",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBCategory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DBItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    shortDesc = table.Column<string>(nullable: true),
                    longDesc = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    isTop = table.Column<bool>(nullable: false),
                    available = table.Column<bool>(nullable: false),
                    category_id = table.Column<int>(nullable: false),
                    item_categoryid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_DBItem_DBCategory_item_categoryid",
                        column: x => x.item_categoryid,
                        principalTable: "DBCategory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DBItem_item_categoryid",
                table: "DBItem",
                column: "item_categoryid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBItem");

            migrationBuilder.DropTable(
                name: "DBCategory");
        }
    }
}

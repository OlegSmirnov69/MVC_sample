using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop1.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DBOrder",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    adress = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    order_time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBOrder", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DBOrderDetail",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(nullable: false),
                    item_id = table.Column<int>(nullable: false),
                    price = table.Column<long>(nullable: false),
                    itemid = table.Column<int>(nullable: true),
                    orderid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBOrderDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_DBOrderDetail_DBItem_itemid",
                        column: x => x.itemid,
                        principalTable: "DBItem",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DBOrderDetail_DBOrder_orderid",
                        column: x => x.orderid,
                        principalTable: "DBOrder",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DBOrderDetail_itemid",
                table: "DBOrderDetail",
                column: "itemid");

            migrationBuilder.CreateIndex(
                name: "IX_DBOrderDetail_orderid",
                table: "DBOrderDetail",
                column: "orderid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBOrderDetail");

            migrationBuilder.DropTable(
                name: "DBOrder");
        }
    }
}

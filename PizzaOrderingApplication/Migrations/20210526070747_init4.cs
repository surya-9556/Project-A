using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderingApplication.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PizzaName1",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PizzaName2",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PizzaName1",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "PizzaName2",
                table: "OrderDetails");
        }
    }
}

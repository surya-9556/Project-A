using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderingApplication.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_PizzaDetails_PizzaDetailsPizzaID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_PizzaDetailsPizzaID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "FinalAmount",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "PizzaDetailsPizzaID",
                table: "OrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsOrderId",
                table: "PizzaDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PizzaDetails_OrderDetailsOrderId",
                table: "PizzaDetails",
                column: "OrderDetailsOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaDetails_OrderDetails_OrderDetailsOrderId",
                table: "PizzaDetails",
                column: "OrderDetailsOrderId",
                principalTable: "OrderDetails",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaDetails_OrderDetails_OrderDetailsOrderId",
                table: "PizzaDetails");

            migrationBuilder.DropIndex(
                name: "IX_PizzaDetails_OrderDetailsOrderId",
                table: "PizzaDetails");

            migrationBuilder.DropColumn(
                name: "OrderDetailsOrderId",
                table: "PizzaDetails");

            migrationBuilder.AddColumn<double>(
                name: "FinalAmount",
                table: "OrderDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "PizzaDetailsPizzaID",
                table: "OrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PizzaDetailsPizzaID",
                table: "OrderDetails",
                column: "PizzaDetailsPizzaID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_PizzaDetails_PizzaDetailsPizzaID",
                table: "OrderDetails",
                column: "PizzaDetailsPizzaID",
                principalTable: "PizzaDetails",
                principalColumn: "PizzaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

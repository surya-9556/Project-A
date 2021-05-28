using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderingApplication.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PizzaDetails",
                columns: table => new
                {
                    PizzaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PizzaSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PizzaType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PizzaSecality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PizzaPrice = table.Column<double>(type: "float", nullable: false),
                    PizzaImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaDetails", x => x.PizzaID);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crusting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Toppings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PizzaDetailsPizzaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_PizzaDetails_PizzaDetailsPizzaID",
                        column: x => x.PizzaDetailsPizzaID,
                        principalTable: "PizzaDetails",
                        principalColumn: "PizzaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PizzaDetailsPizzaID",
                table: "OrderDetails",
                column: "PizzaDetailsPizzaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "PizzaDetails");
        }
    }
}

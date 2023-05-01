using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTraveler.Migrations
{
    public partial class Card : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCardInfos",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCardInfos", x => x.CardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditCardInfos");
        }
    }
}

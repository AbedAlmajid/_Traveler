using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTraveler.Migrations
{
    public partial class Payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentPackages",
                columns: table => new
                {
                    CardPackageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingPackageId = table.Column<int>(type: "int", nullable: true),
                    TicketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPackages", x => x.CardPackageId);
                    table.ForeignKey(
                        name: "FK_PaymentPackages_BookingPackages_BookingPackageId",
                        column: x => x.BookingPackageId,
                        principalTable: "BookingPackages",
                        principalColumn: "BookingPackageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentPackages_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPackages_BookingPackageId",
                table: "PaymentPackages",
                column: "BookingPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPackages_TicketId",
                table: "PaymentPackages",
                column: "TicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentPackages");
        }
    }
}

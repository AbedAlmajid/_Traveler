using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTraveler.Migrations
{
    public partial class userticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserTickets_BookingId",
                table: "UserTickets");

            migrationBuilder.DropIndex(
                name: "IX_UserTickets_TicketId",
                table: "UserTickets");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_UserTickets_BookingId",
                table: "UserTickets",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTickets_TicketId",
                table: "UserTickets",
                column: "TicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserTickets_BookingId",
                table: "UserTickets");

            migrationBuilder.DropIndex(
                name: "IX_UserTickets_TicketId",
                table: "UserTickets");

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserTickets_BookingId",
                table: "UserTickets",
                column: "BookingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserTickets_TicketId",
                table: "UserTickets",
                column: "TicketId",
                unique: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTraveler.Migrations
{
    public partial class boo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Bookings_BookingId1",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_BookingId1",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "BookingId1",
                table: "Bookings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingId1",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BookingId1",
                table: "Bookings",
                column: "BookingId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Bookings_BookingId1",
                table: "Bookings",
                column: "BookingId1",
                principalTable: "Bookings",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTraveler.Migrations
{
    public partial class Packag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTickets_BookingPackages_BookingPackageId",
                table: "UserTickets");

            migrationBuilder.DropIndex(
                name: "IX_UserTickets_BookingPackageId",
                table: "UserTickets");

            migrationBuilder.DropColumn(
                name: "BookingPackageId",
                table: "UserTickets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingPackageId",
                table: "UserTickets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserTickets_BookingPackageId",
                table: "UserTickets",
                column: "BookingPackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTickets_BookingPackages_BookingPackageId",
                table: "UserTickets",
                column: "BookingPackageId",
                principalTable: "BookingPackages",
                principalColumn: "BookingPackageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

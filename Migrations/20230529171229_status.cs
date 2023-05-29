using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTraveler.Migrations
{
    public partial class status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentPackages_Tickets_TicketId",
                table: "PaymentPackages");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "PaymentPackages",
                newName: "PackageId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentPackages_TicketId",
                table: "PaymentPackages",
                newName: "IX_PaymentPackages_PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentPackages_Packages_PackageId",
                table: "PaymentPackages",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "PackageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentPackages_Packages_PackageId",
                table: "PaymentPackages");

            migrationBuilder.RenameColumn(
                name: "PackageId",
                table: "PaymentPackages",
                newName: "TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentPackages_PackageId",
                table: "PaymentPackages",
                newName: "IX_PaymentPackages_TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentPackages_Tickets_TicketId",
                table: "PaymentPackages",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

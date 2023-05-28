using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTraveler.Migrations
{
    public partial class Packa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTickets_Packages_PackageId",
                table: "UserTickets");

            migrationBuilder.DropIndex(
                name: "IX_UserTickets_PackageId",
                table: "UserTickets");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "UserTickets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PackageId",
                table: "UserTickets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserTickets_PackageId",
                table: "UserTickets",
                column: "PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTickets_Packages_PackageId",
                table: "UserTickets",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "PackageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

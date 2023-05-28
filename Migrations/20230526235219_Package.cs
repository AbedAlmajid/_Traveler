using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTraveler.Migrations
{
    public partial class Package : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingPackageId",
                table: "UserTickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PackageId",
                table: "UserTickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingPackageId",
                table: "Payments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Packages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookingPackages",
                columns: table => new
                {
                    BookingPackageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingPackages", x => x.BookingPackageId);
                });

            migrationBuilder.CreateTable(
                name: "UserPackages",
                columns: table => new
                {
                    UserPackageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingPackageId = table.Column<int>(type: "int", nullable: false),
                    PackageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPackages", x => x.UserPackageId);
                    table.ForeignKey(
                        name: "FK_UserPackages_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPackages_BookingPackages_BookingPackageId",
                        column: x => x.BookingPackageId,
                        principalTable: "BookingPackages",
                        principalColumn: "BookingPackageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPackages_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTickets_BookingPackageId",
                table: "UserTickets",
                column: "BookingPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTickets_PackageId",
                table: "UserTickets",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_BookingPackageId",
                table: "Payments",
                column: "BookingPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_ApplicationUserId",
                table: "Packages",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPackages_ApplicationUserId",
                table: "UserPackages",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPackages_BookingPackageId",
                table: "UserPackages",
                column: "BookingPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPackages_PackageId",
                table: "UserPackages",
                column: "PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_AspNetUsers_ApplicationUserId",
                table: "Packages",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_BookingPackages_BookingPackageId",
                table: "Payments",
                column: "BookingPackageId",
                principalTable: "BookingPackages",
                principalColumn: "BookingPackageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTickets_BookingPackages_BookingPackageId",
                table: "UserTickets",
                column: "BookingPackageId",
                principalTable: "BookingPackages",
                principalColumn: "BookingPackageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTickets_Packages_PackageId",
                table: "UserTickets",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "PackageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_AspNetUsers_ApplicationUserId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_BookingPackages_BookingPackageId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTickets_BookingPackages_BookingPackageId",
                table: "UserTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTickets_Packages_PackageId",
                table: "UserTickets");

            migrationBuilder.DropTable(
                name: "UserPackages");

            migrationBuilder.DropTable(
                name: "BookingPackages");

            migrationBuilder.DropIndex(
                name: "IX_UserTickets_BookingPackageId",
                table: "UserTickets");

            migrationBuilder.DropIndex(
                name: "IX_UserTickets_PackageId",
                table: "UserTickets");

            migrationBuilder.DropIndex(
                name: "IX_Payments_BookingPackageId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Packages_ApplicationUserId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "BookingPackageId",
                table: "UserTickets");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "UserTickets");

            migrationBuilder.DropColumn(
                name: "BookingPackageId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Packages");
        }
    }
}

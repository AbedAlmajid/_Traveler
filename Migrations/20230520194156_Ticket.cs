using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTraveler.Migrations
{
    public partial class Ticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Countries_CountryId",
                table: "Packages");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Packages_CountryId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Packages");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Packages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Packages_CountryId",
                table: "Packages",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Countries_CountryId",
                table: "Packages",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

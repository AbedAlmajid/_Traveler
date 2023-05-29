using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTraveler.Migrations
{
    public partial class serve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "BirthDay",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

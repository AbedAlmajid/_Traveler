using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTraveler.Migrations
{
    public partial class Gender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "AspNetUsers",
                newName: "Male");

            migrationBuilder.AddColumn<bool>(
                name: "Female",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Female",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Male",
                table: "AspNetUsers",
                newName: "Gender");
        }
    }
}

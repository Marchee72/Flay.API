using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Migrations
{
    public partial class PruebaClaseHeredada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Renter",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Renter",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Renter");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Renter");
        }
    }
}

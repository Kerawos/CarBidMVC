using Microsoft.EntityFrameworkCore.Migrations;

namespace CarBidMVC.Migrations
{
    public partial class CarModelUpdateDamaged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Damaged",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Damaged",
                table: "Cars");
        }
    }
}

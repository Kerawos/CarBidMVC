using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarBidMVC.Migrations
{
    public partial class CarModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageMiniId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkToAuction",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeAuctionEnd",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeAuctionStart",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ImageMiniId",
                table: "Cars",
                column: "ImageMiniId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_CarId",
                table: "Image",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Image_ImageMiniId",
                table: "Cars",
                column: "ImageMiniId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Image_ImageMiniId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ImageMiniId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ImageMiniId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Info",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "LinkToAuction",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "TimeAuctionEnd",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "TimeAuctionStart",
                table: "Cars");
        }
    }
}

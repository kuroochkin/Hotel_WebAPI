using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Infrastructure.Migrations
{
    public partial class Convenience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirConditioner",
                table: "CategoriesRooms");

            migrationBuilder.DropColumn(
                name: "Bathroom",
                table: "CategoriesRooms");

            migrationBuilder.DropColumn(
                name: "Fridge",
                table: "CategoriesRooms");

            migrationBuilder.DropColumn(
                name: "HairDryer",
                table: "CategoriesRooms");

            migrationBuilder.DropColumn(
                name: "Iron",
                table: "CategoriesRooms");

            migrationBuilder.DropColumn(
                name: "Kettle",
                table: "CategoriesRooms");

            migrationBuilder.DropColumn(
                name: "Tv",
                table: "CategoriesRooms");

            migrationBuilder.DropColumn(
                name: "WiFi",
                table: "CategoriesRooms");

            migrationBuilder.AddColumn<Guid>(
                name: "ConvenienceId",
                table: "CategoriesRooms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Conveniences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Bathroom = table.Column<bool>(type: "bit", nullable: false),
                    Tv = table.Column<bool>(type: "bit", nullable: false),
                    AirConditioner = table.Column<bool>(type: "bit", nullable: false),
                    Fridge = table.Column<bool>(type: "bit", nullable: false),
                    HairDryer = table.Column<bool>(type: "bit", nullable: false),
                    Kettle = table.Column<bool>(type: "bit", nullable: false),
                    Iron = table.Column<bool>(type: "bit", nullable: false),
                    WiFi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conveniences", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesRooms_ConvenienceId",
                table: "CategoriesRooms",
                column: "ConvenienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriesRooms_Conveniences_ConvenienceId",
                table: "CategoriesRooms",
                column: "ConvenienceId",
                principalTable: "Conveniences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriesRooms_Conveniences_ConvenienceId",
                table: "CategoriesRooms");

            migrationBuilder.DropTable(
                name: "Conveniences");

            migrationBuilder.DropIndex(
                name: "IX_CategoriesRooms_ConvenienceId",
                table: "CategoriesRooms");

            migrationBuilder.DropColumn(
                name: "ConvenienceId",
                table: "CategoriesRooms");

            migrationBuilder.AddColumn<bool>(
                name: "AirConditioner",
                table: "CategoriesRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Bathroom",
                table: "CategoriesRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Fridge",
                table: "CategoriesRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HairDryer",
                table: "CategoriesRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Iron",
                table: "CategoriesRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Kettle",
                table: "CategoriesRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tv",
                table: "CategoriesRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WiFi",
                table: "CategoriesRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

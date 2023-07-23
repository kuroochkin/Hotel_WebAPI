using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Infrastructure.Migrations
{
    public partial class CategoryThings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

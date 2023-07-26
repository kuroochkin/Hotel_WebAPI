using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Infrastructure.Migrations
{
    public partial class NullConvenience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriesRooms_Conveniences_ConvenienceId",
                table: "CategoriesRooms");

            migrationBuilder.AlterColumn<Guid>(
                name: "ConvenienceId",
                table: "CategoriesRooms",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriesRooms_Conveniences_ConvenienceId",
                table: "CategoriesRooms",
                column: "ConvenienceId",
                principalTable: "Conveniences",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriesRooms_Conveniences_ConvenienceId",
                table: "CategoriesRooms");

            migrationBuilder.AlterColumn<Guid>(
                name: "ConvenienceId",
                table: "CategoriesRooms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriesRooms_Conveniences_ConvenienceId",
                table: "CategoriesRooms",
                column: "ConvenienceId",
                principalTable: "Conveniences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

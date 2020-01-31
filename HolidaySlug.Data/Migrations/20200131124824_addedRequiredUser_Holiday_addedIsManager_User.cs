using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidaySlug.Data.Migrations
{
    public partial class addedRequiredUser_Holiday_addedIsManager_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_Users_UserID",
                table: "Holidays");

            migrationBuilder.AddColumn<bool>(
                name: "IsManager",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "Holidays",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_Users_UserID",
                table: "Holidays",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_Users_UserID",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "IsManager",
                table: "Users");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "Holidays",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_Users_UserID",
                table: "Holidays",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidaySlug.Data.Migrations
{
    public partial class holidayhistory_madefields_required : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HolidayHistories_Holidays_HolidayID",
                table: "HolidayHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_HolidayHistories_Users_UserID",
                table: "HolidayHistories");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "HolidayHistories",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "HolidayID",
                table: "HolidayHistories",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HolidayHistories_Holidays_HolidayID",
                table: "HolidayHistories",
                column: "HolidayID",
                principalTable: "Holidays",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HolidayHistories_Users_UserID",
                table: "HolidayHistories",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HolidayHistories_Holidays_HolidayID",
                table: "HolidayHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_HolidayHistories_Users_UserID",
                table: "HolidayHistories");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "HolidayHistories",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "HolidayID",
                table: "HolidayHistories",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_HolidayHistories_Holidays_HolidayID",
                table: "HolidayHistories",
                column: "HolidayID",
                principalTable: "Holidays",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HolidayHistories_Users_UserID",
                table: "HolidayHistories",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

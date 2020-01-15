using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidaySlug.Data.Migrations
{
    public partial class removedhardcodedIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_Users_ApprovedByUserID1",
                table: "Holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_Users_UserID1",
                table: "Holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTeams_Users_ManagerID1",
                table: "UserTeams");

            migrationBuilder.DropIndex(
                name: "IX_UserTeams_ManagerID1",
                table: "UserTeams");

            migrationBuilder.DropIndex(
                name: "IX_Holidays_ApprovedByUserID1",
                table: "Holidays");

            migrationBuilder.DropIndex(
                name: "IX_Holidays_UserID1",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "ManagerID1",
                table: "UserTeams");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "UserTeams");

            migrationBuilder.DropColumn(
                name: "ApprovedByUserID1",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "Holidays");

            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerID",
                table: "UserTeams",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "Holidays",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "ApprovedByUserID",
                table: "Holidays",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_UserTeams_ManagerID",
                table: "UserTeams",
                column: "ManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_ApprovedByUserID",
                table: "Holidays",
                column: "ApprovedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_UserID",
                table: "Holidays",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_Users_ApprovedByUserID",
                table: "Holidays",
                column: "ApprovedByUserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_Users_UserID",
                table: "Holidays",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeams_Users_ManagerID",
                table: "UserTeams",
                column: "ManagerID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_Users_ApprovedByUserID",
                table: "Holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_Users_UserID",
                table: "Holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTeams_Users_ManagerID",
                table: "UserTeams");

            migrationBuilder.DropIndex(
                name: "IX_UserTeams_ManagerID",
                table: "UserTeams");

            migrationBuilder.DropIndex(
                name: "IX_Holidays_ApprovedByUserID",
                table: "Holidays");

            migrationBuilder.DropIndex(
                name: "IX_Holidays_UserID",
                table: "Holidays");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerID",
                table: "UserTeams",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ManagerID1",
                table: "UserTeams",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "UserTeams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Holidays",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApprovedByUserID",
                table: "Holidays",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApprovedByUserID1",
                table: "Holidays",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserID1",
                table: "Holidays",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserTeams_ManagerID1",
                table: "UserTeams",
                column: "ManagerID1");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_ApprovedByUserID1",
                table: "Holidays",
                column: "ApprovedByUserID1");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_UserID1",
                table: "Holidays",
                column: "UserID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_Users_ApprovedByUserID1",
                table: "Holidays",
                column: "ApprovedByUserID1",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_Users_UserID1",
                table: "Holidays",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeams_Users_ManagerID1",
                table: "UserTeams",
                column: "ManagerID1",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

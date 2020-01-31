using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidaySlug.Data.Migrations
{
    public partial class ResolvedUserTeamRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTeams_UserTeamID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "UserTeams",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserTeamID",
                table: "Users",
                newName: "UserTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserTeamID",
                table: "Users",
                newName: "IX_Users_UserTeamId");

            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "UserTeams",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserTeams_UserID",
                table: "UserTeams",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTeams_UserTeamId",
                table: "Users",
                column: "UserTeamId",
                principalTable: "UserTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeams_Users_UserID",
                table: "UserTeams",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTeams_UserTeamId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTeams_Users_UserID",
                table: "UserTeams");

            migrationBuilder.DropIndex(
                name: "IX_UserTeams_UserID",
                table: "UserTeams");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "UserTeams");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserTeams",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UserTeamId",
                table: "Users",
                newName: "UserTeamID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserTeamId",
                table: "Users",
                newName: "IX_Users_UserTeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTeams_UserTeamID",
                table: "Users",
                column: "UserTeamID",
                principalTable: "UserTeams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

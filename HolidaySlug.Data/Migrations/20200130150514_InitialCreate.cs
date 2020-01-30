using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidaySlug.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HolidayTypes",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    TeamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    HolidayReason = table.Column<string>(nullable: true),
                    HolidayTypeID = table.Column<Guid>(nullable: true),
                    From = table.Column<DateTime>(nullable: false),
                    To = table.Column<DateTime>(nullable: false),
                    DaysUsed = table.Column<int>(nullable: false),
                    UserID = table.Column<Guid>(nullable: true),
                    Approved = table.Column<bool>(nullable: false),
                    ApprovedByUserID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Holidays_HolidayTypes_HolidayTypeID",
                        column: x => x.HolidayTypeID,
                        principalTable: "HolidayTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTeams",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ManagerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Entitlement = table.Column<int>(nullable: false),
                    UserTeamID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_UserTeams_UserTeamID",
                        column: x => x.UserTeamID,
                        principalTable: "UserTeams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_ApprovedByUserID",
                table: "Holidays",
                column: "ApprovedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_HolidayTypeID",
                table: "Holidays",
                column: "HolidayTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_UserID",
                table: "Holidays",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTeamID",
                table: "Users",
                column: "UserTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_UserTeams_ManagerID",
                table: "UserTeams",
                column: "ManagerID");

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
                name: "FK_UserTeams_Users_ManagerID",
                table: "UserTeams");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "HolidayTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTeams");
        }
    }
}

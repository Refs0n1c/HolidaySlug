using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidaySlug.Data.Migrations
{
    public partial class AddedHolidatHistoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HolidayHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Action = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<Guid>(nullable: true),
                    HolidayID = table.Column<Guid>(nullable: true)
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HolidayHistories_Holidays_HolidayID",
                        column: x => x.HolidayID,
                        principalTable: "Holidays",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                 
                    table.ForeignKey(
                        name: "FK_HolidayHistories_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    
                });

            migrationBuilder.CreateIndex(
                name: "IX_HolidayHistories_HolidayID",
                table: "HolidayHistories",
                column: "HolidayID");

            

            migrationBuilder.CreateIndex(
                name: "IX_HolidayHistories_UserID",
                table: "HolidayHistories",
                column: "UserID");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HolidayHistories");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidaySlug.Data.Migrations
{
    public partial class _addedProjectNamesToUser_added_weeklyHoursToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "WeeklyHours",
                table: "Users",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "Teams",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeeklyHours",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "Teams");
        }
    }
}

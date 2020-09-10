using Microsoft.EntityFrameworkCore.Migrations;

namespace HUDEwiBlazor.Migrations
{
    public partial class SystemSettingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SystemSettings",
                columns: table => new
                {
                    OverTimeMaxPerYear = table.Column<int>(nullable: false),
                    OverTimeMaxPerWeek = table.Column<int>(nullable: false),
                    OverTimeMaxPerDay = table.Column<int>(nullable: false),
                    OverTimePay50PerWeek = table.Column<int>(nullable: false),
                    RestPeriod = table.Column<int>(nullable: false),
                    AttendanceReminderLimit = table.Column<int>(nullable: false),
                    ScheduleGenerateDays = table.Column<int>(nullable: false),
                    HolidaysMaxPerYear = table.Column<int>(nullable: false),
                    HolidaysOnDemandMaxPerYear = table.Column<int>(nullable: false),
                    DayTimeStartHour = table.Column<int>(nullable: false),
                    DayTimeStartMinutes = table.Column<int>(nullable: false),
                    DayTimeEndHour = table.Column<int>(nullable: false),
                    DayTimeEndMinutes = table.Column<int>(nullable: false),
                    BookingEmail = table.Column<string>(nullable: true),
                    ServerIP = table.Column<string>(nullable: true),
                    ServerPort = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemSettings");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace HUDEwiBlazor.Migrations
{
    public partial class NewTablesOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "deputyProjectLeaderID",
                table: "Projects",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmailSettings",
                columns: table => new
                {
                    SmtpServer = table.Column<string>(nullable: true),
                    SmtpPort = table.Column<int>(nullable: false),
                    SmtpUsername = table.Column<string>(nullable: true),
                    SmtpPassword = table.Column<string>(nullable: true),
                    PopServer = table.Column<string>(nullable: true),
                    PopPort = table.Column<int>(nullable: false),
                    PopUsername = table.Column<string>(nullable: true),
                    PopPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_deputyProjectLeaderID",
                table: "Projects",
                column: "deputyProjectLeaderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Employees_deputyProjectLeaderID",
                table: "Projects",
                column: "deputyProjectLeaderID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Employees_deputyProjectLeaderID",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "EmailSettings");

            migrationBuilder.DropIndex(
                name: "IX_Projects_deputyProjectLeaderID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "deputyProjectLeaderID",
                table: "Projects");
        }
    }
}

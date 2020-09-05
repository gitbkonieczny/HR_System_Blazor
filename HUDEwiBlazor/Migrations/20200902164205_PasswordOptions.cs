using Microsoft.EntityFrameworkCore.Migrations;

namespace HUDEwiBlazor.Migrations
{
    public partial class PasswordOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PasswordOptions",
                columns: table => new
                {
                    RequiredLength = table.Column<string>(nullable: true),
                    RequiredUniqueChars = table.Column<string>(nullable: true),
                    RequireDigit = table.Column<string>(nullable: true),
                    RequireLowercase = table.Column<string>(nullable: true),
                    RequireNonAlphanumeric = table.Column<string>(nullable: true),
                    RequireUppercase = table.Column<string>(nullable: true),
                    Secret = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PasswordOptions");
        }
    }
}

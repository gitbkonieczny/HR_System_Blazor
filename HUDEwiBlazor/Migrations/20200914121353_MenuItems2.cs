using Microsoft.EntityFrameworkCore.Migrations;

namespace HUDEwiBlazor.Migrations
{
    public partial class MenuItems2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "MenuItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "MenuItem");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace HUDEwiBlazor.Migrations
{
    public partial class MenuItems3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LinkRolesMenuItem",
                columns: table => new
                {
                    LinkRolesMenuItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(nullable: true),
                    MenuItemID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkRolesMenuItem", x => x.LinkRolesMenuItemID);
                    table.ForeignKey(
                        name: "FK_LinkRolesMenuItem_MenuItem_MenuItemID",
                        column: x => x.MenuItemID,
                        principalTable: "MenuItem",
                        principalColumn: "MenuItemId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_LinkRolesMenuItem_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RolesID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinkRolesMenuItem_MenuItemID",
                table: "LinkRolesMenuItem",
                column: "MenuItemID");

            migrationBuilder.CreateIndex(
                name: "IX_LinkRolesMenuItem_RoleID",
                table: "LinkRolesMenuItem",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkRolesMenuItem");
        }
    }
}

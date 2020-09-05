using Microsoft.EntityFrameworkCore.Migrations;

namespace HUDEwiBlazor.Migrations
{
    public partial class PasswordOptionsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RequiredUniqueChars",
                table: "PasswordOptions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RequiredLength",
                table: "PasswordOptions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RequireUppercase",
                table: "PasswordOptions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RequireNonAlphanumeric",
                table: "PasswordOptions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RequireLowercase",
                table: "PasswordOptions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RequireDigit",
                table: "PasswordOptions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequiredUniqueChars",
                table: "PasswordOptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "RequiredLength",
                table: "PasswordOptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "RequireUppercase",
                table: "PasswordOptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "RequireNonAlphanumeric",
                table: "PasswordOptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "RequireLowercase",
                table: "PasswordOptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "RequireDigit",
                table: "PasswordOptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}

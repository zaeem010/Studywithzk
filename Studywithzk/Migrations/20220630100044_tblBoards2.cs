using Microsoft.EntityFrameworkCore.Migrations;

namespace Studywithzk.Migrations
{
    public partial class tblBoards2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StatesName",
                table: "States",
                type: "nvarchar(455)",
                maxLength: 455,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Countrycode",
                table: "Countrys",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                table: "Countrys",
                type: "nvarchar(455)",
                maxLength: 455,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BoardName",
                table: "Boards",
                type: "nvarchar(455)",
                maxLength: 455,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StatesName",
                table: "States",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(455)",
                oldMaxLength: 455,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Countrycode",
                table: "Countrys",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                table: "Countrys",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(455)",
                oldMaxLength: 455,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BoardName",
                table: "Boards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(455)",
                oldMaxLength: 455);
        }
    }
}

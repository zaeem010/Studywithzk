using Microsoft.EntityFrameworkCore.Migrations;

namespace Studywithzk.Migrations
{
    public partial class tblExamClass1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamClass_Boards_BoardsId",
                table: "ExamClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamClass_Countrys_CountrysId",
                table: "ExamClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamClass_States_StatesId",
                table: "ExamClass");

            migrationBuilder.DropIndex(
                name: "IX_ExamClass_BoardsId",
                table: "ExamClass");

            migrationBuilder.DropIndex(
                name: "IX_ExamClass_CountrysId",
                table: "ExamClass");

            migrationBuilder.DropIndex(
                name: "IX_ExamClass_StatesId",
                table: "ExamClass");

            migrationBuilder.DropColumn(
                name: "BoardsId",
                table: "ExamClass");

            migrationBuilder.DropColumn(
                name: "CountrysId",
                table: "ExamClass");

            migrationBuilder.DropColumn(
                name: "StatesId",
                table: "ExamClass");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BoardsId",
                table: "ExamClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CountrysId",
                table: "ExamClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StatesId",
                table: "ExamClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_ExamClass_BoardsId",
                table: "ExamClass",
                column: "BoardsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamClass_CountrysId",
                table: "ExamClass",
                column: "CountrysId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamClass_StatesId",
                table: "ExamClass",
                column: "StatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamClass_Boards_BoardsId",
                table: "ExamClass",
                column: "BoardsId",
                principalTable: "Boards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamClass_Countrys_CountrysId",
                table: "ExamClass",
                column: "CountrysId",
                principalTable: "Countrys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamClass_States_StatesId",
                table: "ExamClass",
                column: "StatesId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

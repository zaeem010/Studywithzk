using Microsoft.EntityFrameworkCore.Migrations;

namespace Studywithzk.Migrations
{
    public partial class tblUnsolvedPaper2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UnsolvedPaper_BoardsId",
                table: "UnsolvedPaper",
                column: "BoardsId");

            migrationBuilder.CreateIndex(
                name: "IX_UnsolvedPaper_CountrysId",
                table: "UnsolvedPaper",
                column: "CountrysId");

            migrationBuilder.CreateIndex(
                name: "IX_UnsolvedPaper_ExamClassId",
                table: "UnsolvedPaper",
                column: "ExamClassId");

            migrationBuilder.CreateIndex(
                name: "IX_UnsolvedPaper_ExamSubjectId",
                table: "UnsolvedPaper",
                column: "ExamSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UnsolvedPaper_ExamYearId",
                table: "UnsolvedPaper",
                column: "ExamYearId");

            migrationBuilder.CreateIndex(
                name: "IX_UnsolvedPaper_StatesId",
                table: "UnsolvedPaper",
                column: "StatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_UnsolvedPaper_Boards_BoardsId",
                table: "UnsolvedPaper",
                column: "BoardsId",
                principalTable: "Boards",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UnsolvedPaper_Countrys_CountrysId",
                table: "UnsolvedPaper",
                column: "CountrysId",
                principalTable: "Countrys",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UnsolvedPaper_ExamClass_ExamClassId",
                table: "UnsolvedPaper",
                column: "ExamClassId",
                principalTable: "ExamClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UnsolvedPaper_ExamSubject_ExamSubjectId",
                table: "UnsolvedPaper",
                column: "ExamSubjectId",
                principalTable: "ExamSubject",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UnsolvedPaper_ExamYear_ExamYearId",
                table: "UnsolvedPaper",
                column: "ExamYearId",
                principalTable: "ExamYear",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UnsolvedPaper_States_StatesId",
                table: "UnsolvedPaper",
                column: "StatesId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnsolvedPaper_Boards_BoardsId",
                table: "UnsolvedPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_UnsolvedPaper_Countrys_CountrysId",
                table: "UnsolvedPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_UnsolvedPaper_ExamClass_ExamClassId",
                table: "UnsolvedPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_UnsolvedPaper_ExamSubject_ExamSubjectId",
                table: "UnsolvedPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_UnsolvedPaper_ExamYear_ExamYearId",
                table: "UnsolvedPaper");

            migrationBuilder.DropForeignKey(
                name: "FK_UnsolvedPaper_States_StatesId",
                table: "UnsolvedPaper");

            migrationBuilder.DropIndex(
                name: "IX_UnsolvedPaper_BoardsId",
                table: "UnsolvedPaper");

            migrationBuilder.DropIndex(
                name: "IX_UnsolvedPaper_CountrysId",
                table: "UnsolvedPaper");

            migrationBuilder.DropIndex(
                name: "IX_UnsolvedPaper_ExamClassId",
                table: "UnsolvedPaper");

            migrationBuilder.DropIndex(
                name: "IX_UnsolvedPaper_ExamSubjectId",
                table: "UnsolvedPaper");

            migrationBuilder.DropIndex(
                name: "IX_UnsolvedPaper_ExamYearId",
                table: "UnsolvedPaper");

            migrationBuilder.DropIndex(
                name: "IX_UnsolvedPaper_StatesId",
                table: "UnsolvedPaper");
        }
    }
}

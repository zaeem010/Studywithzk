using Microsoft.EntityFrameworkCore.Migrations;

namespace Studywithzk.Migrations
{
    public partial class tblExamClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamClass",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    className = table.Column<string>(type: "nvarchar(455)", maxLength: 455, nullable: false),
                    CountrysId = table.Column<long>(type: "bigint", nullable: false),
                    StatesId = table.Column<long>(type: "bigint", nullable: false),
                    BoardsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamClass_Boards_BoardsId",
                        column: x => x.BoardsId,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamClass_Countrys_CountrysId",
                        column: x => x.CountrysId,
                        principalTable: "Countrys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ExamClass_States_StatesId",
                        column: x => x.StatesId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamClass");
        }
    }
}

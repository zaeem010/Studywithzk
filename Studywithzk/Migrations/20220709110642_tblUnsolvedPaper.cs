using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Studywithzk.Migrations
{
    public partial class tblUnsolvedPaper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnsolvedPaper",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountrysId = table.Column<long>(type: "bigint", nullable: false),
                    StatesId = table.Column<long>(type: "bigint", nullable: false),
                    BoardsId = table.Column<long>(type: "bigint", nullable: false),
                    ExamClassId = table.Column<long>(type: "bigint", nullable: false),
                    ExamYearId = table.Column<long>(type: "bigint", nullable: false),
                    ExamSubjectId = table.Column<long>(type: "bigint", nullable: false),
                    UnSolved = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Verify = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnsolvedPaper", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnsolvedPaper");
        }
    }
}

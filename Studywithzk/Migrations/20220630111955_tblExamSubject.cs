using Microsoft.EntityFrameworkCore.Migrations;

namespace Studywithzk.Migrations
{
    public partial class tblExamSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamSubject",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(455)", maxLength: 455, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamSubject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamYear",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearName = table.Column<string>(type: "nvarchar(455)", maxLength: 455, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamYear", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamSubject");

            migrationBuilder.DropTable(
                name: "ExamYear");
        }
    }
}

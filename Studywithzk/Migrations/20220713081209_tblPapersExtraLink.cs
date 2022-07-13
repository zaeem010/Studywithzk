using Microsoft.EntityFrameworkCore.Migrations;

namespace Studywithzk.Migrations
{
    public partial class tblPapersExtraLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaperPath",
                table: "UnsolvedPaper",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PapersExtraLink",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnsolvedPaperId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PathLink = table.Column<string>(type: "nvarchar(455)", maxLength: 455, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PapersExtraLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PapersExtraLink_UnsolvedPaper_UnsolvedPaperId",
                        column: x => x.UnsolvedPaperId,
                        principalTable: "UnsolvedPaper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PapersExtraLink_UnsolvedPaperId",
                table: "PapersExtraLink",
                column: "UnsolvedPaperId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PapersExtraLink");

            migrationBuilder.DropColumn(
                name: "PaperPath",
                table: "UnsolvedPaper");
        }
    }
}

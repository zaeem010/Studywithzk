using Microsoft.EntityFrameworkCore.Migrations;

namespace Studywithzk.Migrations
{
    public partial class tblBoards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountrysId = table.Column<long>(type: "bigint", nullable: false),
                    StatesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boards_Countrys_CountrysId",
                        column: x => x.CountrysId,
                        principalTable: "Countrys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Boards_States_StatesId",
                        column: x => x.StatesId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boards_CountrysId",
                table: "Boards",
                column: "CountrysId");

            migrationBuilder.CreateIndex(
                name: "IX_Boards_StatesId",
                table: "Boards",
                column: "StatesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boards");
        }
    }
}

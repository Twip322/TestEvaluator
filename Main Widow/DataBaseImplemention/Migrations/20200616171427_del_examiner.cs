using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBaseImplemention.Migrations
{
    public partial class del_examiner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quest = table.Column<string>(nullable: true),
                    ansewrs = table.Column<string>(nullable: true),
                    rightNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    testName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestsQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestId = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    questName = table.Column<string>(nullable: true),
                    answers = table.Column<string>(nullable: true),
                    rightNum = table.Column<int>(nullable: false),
                    testsId = table.Column<int>(nullable: true),
                    QuestID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestsQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestsQuestions_Questions_QuestID",
                        column: x => x.QuestID,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestsQuestions_Tests_testsId",
                        column: x => x.testsId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestsQuestions_QuestID",
                table: "TestsQuestions",
                column: "QuestID");

            migrationBuilder.CreateIndex(
                name: "IX_TestsQuestions_testsId",
                table: "TestsQuestions",
                column: "testsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestsQuestions");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Tests");
        }
    }
}

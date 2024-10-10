using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class Add_CartTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentCourseCart",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseCart", x => new { x.UserId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourseCart_AspNetUsers_UsersId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourseCart_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseCart_CourseId",
                table: "StudentCourseCart",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseCart_UsersId",
                table: "StudentCourseCart",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourseCart");
        }
    }
}

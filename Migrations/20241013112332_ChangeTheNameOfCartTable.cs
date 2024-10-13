using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTheNameOfCartTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourseCart");

            migrationBuilder.CreateTable(
                name: "UserCoursesCart",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCoursesCart", x => new { x.CourseId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserCoursesCart_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCoursesCart_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fa702d4f-85bb-4a41-85a9-284cb02e974b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6333865a-bcde-43de-b01a-62c46a969562");

            migrationBuilder.CreateIndex(
                name: "IX_UserCoursesCart_UserId",
                table: "UserCoursesCart",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCoursesCart");

            migrationBuilder.CreateTable(
                name: "StudentCourseCart",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseCart", x => new { x.UserId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourseCart_AspNetUsers_UsersId",
                        column: x => x.UsersId,
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2b0e329a-e10e-4f4e-a4eb-fb497c16f7a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "949fac39-8bed-4a6c-92fe-f628d5471ed7");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseCart_CourseId",
                table: "StudentCourseCart",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseCart_UsersId",
                table: "StudentCourseCart",
                column: "UsersId");
        }
    }
}

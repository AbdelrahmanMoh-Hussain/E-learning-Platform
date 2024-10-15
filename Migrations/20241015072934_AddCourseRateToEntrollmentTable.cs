using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseRateToEntrollmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CourseRate",
                table: "Enrollement",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e2b6b62a-da27-4935-a21f-c86176508be9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "53038ecd-1e33-4ae6-bbbb-53290c38adcf");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseRate",
                table: "Enrollement");

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
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class AddVideoUrlColumToCourseTableAndSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Course",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "84fd0f35-5948-4fd2-819b-9d38693a2f9c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0c9ad23a-d23e-4c9d-aaa8-485e04f3e005");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=kqtD5dpn9C8&ab_channel=ProgrammingwithMosh");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=nU-IIXBWlS4&ab_channel=Simplilearn");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=ua-CiDNNj30&ab_channel=Simplilearn");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=b2fyFJ_GHz8&ab_channel=TheCreativePenn");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=YYFb82XDpAc&ab_channel=AccountingStuff");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=QO4NXhWo_NM&ab_channel=TraversyMedia");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=nU-IIXBWlS4&ab_channel=Simplilearnt");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=_ljLREvx5zo&ab_channel=Simplilearn");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=nU-IIXBWlS4&ab_channel=Simplilearn");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                column: "VideoUrl",
                value: "https://www.youtube.com/watch?v=SSo_EIwHSd4&ab_channel=Simplilearn");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Course");

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
    }
}

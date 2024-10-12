using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class Seed_Courses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseRate", "Description", "FieldOfStudy", "ImageUrl", "InstructorName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 0m, "Learn the basics of Python programming, from syntax to algorithms.", "Computer Science", "python.jpg", "John Doe", "Introduction to Python", 199.99m },
                    { 2, 0m, "A beginner's guide to digital marketing and online strategies.", "Marketing", "digital_marketing.jpg", "Jane Smith", "Digital Marketing 101", 149.99m },
                    { 3, 0m, "Explore data analysis techniques, statistics, and machine learning basics.", "Data Science", "data_science.jpg", "Dr. Sarah Lee", "Data Science Fundamentals", 499.99m },
                    { 4, 0m, "Improve your creative writing skills through interactive sessions.", "Literature", "creative_writing.jpg", "Robert Martin", "Creative Writing Workshop", 129.99m },
                    { 5, 0m, "An introductory course on financial accounting and bookkeeping.", "Finance", "financial_accounting.jpg", "Anna Brown", "Financial Accounting for Beginners", 299.99m },
                    { 6, 0m, "Master advanced JavaScript concepts such as closures, asynchronous programming, and more.", "Computer Science", "javascript.jpg", "Michael Johnson", "Advanced JavaScript", 249.99m },
                    { 7, 0m, "Learn the fundamentals of UX/UI design and how to create user-friendly interfaces.", "Design", "uiux.jpg", "Emily Clark", "Introduction to UX/UI Design", 179.99m },
                    { 8, 0m, "A course for beginners to understand the basics of project management methodologies and tools.", "Management", "project_management.jpg", "David Williams", "Project Management Essentials", 199.99m },
                    { 9, 0m, "Learn the essentials of Adobe Photoshop for image editing and graphic design.", "Design", "photoshop.jpg", "Sophia White", "Mastering Adobe Photoshop", 159.99m },
                    { 10, 0m, "An introductory course to understand blockchain technology and cryptocurrencies.", "Finance", "cryptocurrency.jpg", "Chris Thompson", "Blockchain and Cryptocurrency Basics", 399.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5ffd1ba9-75dd-4ab4-a037-df843b846873");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4980cfae-deee-4dd5-beae-5cfe6caf8b2a");
        }
    }
}

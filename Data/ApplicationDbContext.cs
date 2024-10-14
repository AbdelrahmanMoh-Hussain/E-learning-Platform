using E_learning_Platform.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Platform.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public DbSet<Course> Course { get; set; }
        public DbSet<Enrollement> Enrollement { get; set; }
        public DbSet<UserCoursesCart> UserCoursesCart { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Enrollement>()
                .HasKey(e => new {e.CourseId, e.UserId});

            modelBuilder.Entity<UserCoursesCart>()
                .HasKey(e => new { e.CourseId, e.UserId });

            modelBuilder.Entity<Course>().HasMany(c => c.Users)
                .WithMany(u => u.Courses)
                .UsingEntity<Enrollement>();

			modelBuilder.Entity<Course>().HasMany(c => c.Users)
				.WithMany(u => u.Courses)
				.UsingEntity<UserCoursesCart>();

            modelBuilder.Entity<IdentityRole<int>>()
                .HasData(new[] 
                {
                    new IdentityRole<int> {Id= 1, Name = "admin", NormalizedName = "admin".ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
                    new IdentityRole<int> { Id = 2, Name = "student", NormalizedName = "student".ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
                });


            // Seed 10 real course data entries
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Name = "Introduction to Python",
                    Description = "Learn the basics of Python programming, from syntax to algorithms.",
                    CourseRate = 0,
                    ImageUrl = "python.jpg",
                    FieldOfStudy = "Computer Science",
                    InstructorName = "John Doe",
                    Price = 199.99m
                },
                new Course
                {
                    Id = 2,
                    Name = "Digital Marketing 101",
                    Description = "A beginner's guide to digital marketing and online strategies.",
                    CourseRate = 0,
                    ImageUrl = "digital_marketing.jpg",
                    FieldOfStudy = "Marketing",
                    InstructorName = "Jane Smith",
                    Price = 149.99m
                },
                new Course
                {
                    Id = 3,
                    Name = "Data Science Fundamentals",
                    Description = "Explore data analysis techniques, statistics, and machine learning basics.",
                    CourseRate = 0,
                    ImageUrl = "data_science.jpg",
                    FieldOfStudy = "Data Science",
                    InstructorName = "Dr. Sarah Lee",
                    Price = 499.99m
                },
                new Course
                {
                    Id = 4,
                    Name = "Creative Writing Workshop",
                    Description = "Improve your creative writing skills through interactive sessions.",
                    CourseRate = 0,
                    ImageUrl = "creative_writing.jpg",
                    FieldOfStudy = "Literature",
                    InstructorName = "Robert Martin",
                    Price = 129.99m
                },
                new Course
                {
                    Id = 5,
                    Name = "Financial Accounting for Beginners",
                    Description = "An introductory course on financial accounting and bookkeeping.",
                    CourseRate = 0,
                    ImageUrl = "financial_accounting.jpg",
                    FieldOfStudy = "Finance",
                    InstructorName = "Anna Brown",
                    Price = 299.99m
                },
                new Course
                {
                    Id = 6,
                    Name = "Advanced JavaScript",
                    Description = "Master advanced JavaScript concepts such as closures, asynchronous programming, and more.",
                    CourseRate = 0,
                    ImageUrl = "javascript.jpg",
                    FieldOfStudy = "Computer Science",
                    InstructorName = "Michael Johnson",
                    Price = 249.99m
                },
                new Course
                {
                    Id = 7,
                    Name = "Introduction to UX/UI Design",
                    Description = "Learn the fundamentals of UX/UI design and how to create user-friendly interfaces.",
                    CourseRate = 0,
                    ImageUrl = "uiux.jpg",
                    FieldOfStudy = "Design",
                    InstructorName = "Emily Clark",
                    Price = 179.99m
                },
                new Course
                {
                    Id = 8,
                    Name = "Project Management Essentials",
                    Description = "A course for beginners to understand the basics of project management methodologies and tools.",
                    CourseRate = 0,
                    ImageUrl = "project_management.jpg",
                    FieldOfStudy = "Management",
                    InstructorName = "David Williams",
                    Price = 199.99m
                },
                new Course
                {
                    Id = 9,
                    Name = "Mastering Adobe Photoshop",
                    Description = "Learn the essentials of Adobe Photoshop for image editing and graphic design.",
                    CourseRate = 0,
                    ImageUrl = "photoshop.jpg",
                    FieldOfStudy = "Design",
                    InstructorName = "Sophia White",
                    Price = 159.99m
                },
                new Course
                {
                    Id = 10,
                    Name = "Blockchain and Cryptocurrency Basics",
                    Description = "An introductory course to understand blockchain technology and cryptocurrencies.",
                    CourseRate = 0,
                    ImageUrl = "cryptocurrency.jpg",
                    FieldOfStudy = "Finance",
                    InstructorName = "Chris Thompson",
                    Price = 399.99m
                }
            );
        }
    }
}

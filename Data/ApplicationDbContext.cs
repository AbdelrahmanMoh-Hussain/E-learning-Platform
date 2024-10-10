using E_learning_Platform.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Platform.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        DbSet<Course> Course { get; set; }
        DbSet<Enrollement> Enrollement { get; set; }
        DbSet<StudentCourseCart> StudentCourseCart { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Enrollement>()
                .HasKey(e => new {e.CourseId, e.UserId});

            modelBuilder.Entity<StudentCourseCart>()
                .HasKey(e => new { e.UserId, e.CourseId });

            modelBuilder.Entity<Course>().HasMany(c => c.Users)
                .WithMany(u => u.Courses)
                .UsingEntity<Enrollement>();

			modelBuilder.Entity<Course>().HasMany(c => c.Users)
				.WithMany(u => u.Courses)
				.UsingEntity<StudentCourseCart>();

            modelBuilder.Entity<IdentityRole<int>>()
                .HasData(new[] 
                {
                    new IdentityRole<int> {Id= 1, Name = "admin", NormalizedName = "admin".ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
                    new IdentityRole<int> { Id = 2, Name = "student", NormalizedName = "student".ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() },
                });
		}
    }
}

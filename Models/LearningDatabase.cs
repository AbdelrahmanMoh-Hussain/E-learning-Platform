using Microsoft.EntityFrameworkCore;

namespace E_learning_Platform.Models
{
    public class E_LearningDatabase:DbContext
    {
        DbSet<Course> Course { get; set; }
        DbSet<Enrollement> Enrollement { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data Source=.\sqlexpress;Initial Catalog=ELearningPlatform;integrated security=True;Encrypt=False;Trust server certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}

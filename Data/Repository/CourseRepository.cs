using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Platform.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            return await _context.Course.AsNoTracking().ToListAsync();
        }

        public async Task<Course?> GetByIdAsync(int id)
        {
            return await _context.Course.FindAsync(id);
        }

        public async Task AddCourseAsync(Course course)
        {
            await _context.Course.AddAsync(course);
            await _context.SaveChangesAsync();
        }

        public async Task<Course?> UpdateCourseAsync(int courseId, Course course)
        {
            var courseToUpdate = await GetByIdAsync(courseId);
            if (courseToUpdate == null)
                return null;
            _context.Course.Entry(courseToUpdate).CurrentValues.SetValues(course);
            await _context.SaveChangesAsync();

            return courseToUpdate;
        }
        public async Task DeleteCourseAsync(int courseId)
        {
            var courseToDelete = await GetByIdAsync(courseId);
            if (courseToDelete == null)
                return;
            
            _context.Course.Remove(courseToDelete);
            await _context.SaveChangesAsync();
        }
    }
}

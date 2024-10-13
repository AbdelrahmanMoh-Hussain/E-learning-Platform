using E_learning_Platform.Models;

namespace E_learning_Platform.Data.Repository.Interfaces
{
    public interface ICourseRepository
    {
        public Task<IEnumerable<Course>> GetAllAsync();
        public Task<Course?> GetByIdAsync(int id);
        public Task AddCourseAsync(Course course);
        public Task<Course?> UpdateCourseAsync(int courseId, Course course);
        public Task DeleteCourseAsync(int courseId);
    }
}

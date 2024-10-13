using E_learning_Platform.Models;

namespace E_learning_Platform.Data.Repository.Interfaces
{
    public interface ICartRepository
    {
        public IEnumerable<Course?> GetUserCartCourses(int userId);
        public Task<bool> RemoveCourseFromUserCartAsync(int courseId, int userId);
    }
}

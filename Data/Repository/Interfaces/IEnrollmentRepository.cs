using E_learning_Platform.Models;

namespace E_learning_Platform.Data.Repository.Interfaces
{
    public interface IEnrollmentRepository
    {
        public Task<bool> AddEnrollmentsAsync(int userId, IEnumerable<Course> courses);
        public Task<IEnumerable<Enrollement>> GetAllAsync(int userId);
        public Task<bool> AddCourseUserRateAsync(int userId, int courseId, int rate);
        public Task<bool> CompletePrograssAsync(int userId, int courseId);
    }
}

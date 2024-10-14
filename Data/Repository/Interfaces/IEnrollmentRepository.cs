using E_learning_Platform.Models;

namespace E_learning_Platform.Data.Repository.Interfaces
{
    public interface IEnrollmentRepository
    {
        public Task<bool> AddEnrollmentsAsync(int userId, IEnumerable<Course> courses);
        public Task<IEnumerable<Enrollement>> GetAllAsync(int userId);
    }
}

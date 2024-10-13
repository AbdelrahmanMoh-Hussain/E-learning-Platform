using E_learning_Platform.Models;

namespace E_learning_Platform.Data.Repository.Interfaces
{
    public interface IEnrollmentRepository
    {
        public IEnumerable<Enrollement> AddEnrollments(int userId, IEnumerable<Course> courses);
    }
}

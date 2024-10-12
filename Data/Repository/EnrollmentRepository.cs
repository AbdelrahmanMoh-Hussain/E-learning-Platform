using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;

namespace E_learning_Platform.Data.Repository
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Enrollement> AddEnrollments(int userId, List<Course> courses)
        {
            List<Enrollement> enrollements = new List<Enrollement>();
            foreach (var course in courses)
            {
                var enrollment = new Enrollement
                {
                    UserId = userId,
                    CourseId = course.Id
                };
                _context.Enrollement.Add(enrollment);
                var effectedRows = _context.SaveChanges();
                if(effectedRows > 0)
                {
                    enrollements.Add(enrollment);
                }
            }
            return enrollements;

        }
    }
}

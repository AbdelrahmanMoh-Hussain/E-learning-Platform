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

        public IEnumerable<Enrollement> AddEnrollments(int userId, IEnumerable<Course> courses)
        {
            List<Enrollement> enrollements = new List<Enrollement>();
            foreach (var course in courses)
            {
                var enrollment = new Enrollement
                {
                    UserId = userId,
                    CourseId = course.Id,
                    Progress = new Random().Next(0, 100)

                };
                _context.Enrollement.Add(enrollment);
                _context.UserCoursesCart.Remove(new UserCoursesCart { CourseId = course.Id, UserId = userId });
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

using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;

namespace E_learning_Platform.Data.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _context;

        public CartRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course?> GetUserCartCourses(int userId)
        {
            var coursesId = _context.StudentCourseCart.Where(c => c.UserId == userId)
                                .Select(c => c.CourseId)
                                .ToList();

            List<Course> courses = new List<Course>();
            foreach (var c in coursesId)
            {
                var course = _context.Course.Find(c);
                if(course is not null) 
                    courses.Add(course);

            }
            return courses;
        }

        public void RemoveCourseFromUserCart(int courseId, int userId)
        {
            var cartItemToRemove = _context.StudentCourseCart
                .FirstOrDefault(c => c.UserId == userId && c.CourseId == courseId);
            if (cartItemToRemove == null)
                return;

            _context.StudentCourseCart.Remove(cartItemToRemove);
            _context.SaveChanges();
        }

        
    }
}

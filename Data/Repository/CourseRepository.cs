using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;

namespace E_learning_Platform.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Course course)
        {
            _context.Course.Add(course);
        }

        public void DeleteByID(int id)
        {
            Course course=GetById(id);
            _context.Remove(course);
        }

        public List<Course> GetAll()
        {
            return _context.Course.ToList();
        }

        public Course GetById(int id)
        {
            Course course=_context.Course.FirstOrDefault(c => c.Id == id);
            return course;
        }

        public void saveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Course course)
        {
            _context.Update(course);  
        }
    }
}

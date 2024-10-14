using E_learning_Platform.Models;

namespace E_learning_Platform.Data.Repository.Interfaces
{
    public interface ICourseRepository
    {

        //CRUD operations 

        public void Create(Course course);
        public List<Course> GetAll();

        public Course GetById(int id);
        public void Update(Course course);
        public void DeleteByID(int id);
        public void saveChanges();
    }
}

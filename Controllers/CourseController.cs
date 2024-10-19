using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;
using E_learning_Platform.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_learning_Platform.Controllers
{
    [Authorize(Roles = "admin")]

    public class CourseController : Controller
    {
        private readonly ICourseRepository courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }
        //endpoint = /Course/index
        public IActionResult Index()
        {
            List<Course>courses=courseRepository.GetAll();
            return View("Index",courses);
        }

        public IActionResult AddCourse() {

            Course course = new Course();

            return View("AddCourse", course);
            
        }
        [HttpPost]
        public IActionResult SaveCourse(Course courseFromReq)
        {
            if (ModelState.IsValid)
            {
                courseRepository.Create(courseFromReq);
                courseRepository.saveChanges();

                //go to home
                List<Course> courses = courseRepository.GetAll();
                return View("Index", courses);
            }

            return View("AddCourse", courseFromReq);
        }

        public IActionResult Delete(int id)
        {
            courseRepository.DeleteByID(id);
            courseRepository.saveChanges();
            return RedirectToAction("Index", courseRepository.GetAll());
        }

        public IActionResult Edit(int id)
        {
            
            
            return View("Edit", courseRepository.GetById(id));
        }
        public IActionResult SaveEdit(Course courseFromReq)
        {
            if (ModelState.IsValid)
            {

                courseRepository.Update(courseFromReq);
                courseRepository.saveChanges();
                return RedirectToAction("Index", courseRepository.GetAll());
            }

            return View("Edit", courseFromReq); 
        }
    }
}

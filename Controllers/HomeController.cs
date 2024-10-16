using E_learning_Platform.Data;
using E_learning_Platform.Data.Repository;
using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;
using E_learning_Platform.Models.ViewModels;
using E_learning_Platform.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_learning_Platform.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICourseRepository _courseRepository;

        public HomeController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }


        public IActionResult Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;  

            List<Course> courses = _courseRepository.GetAll();

            if (!string.IsNullOrEmpty(searchString))
            {
                
                courses = courses.Where(c => c.Name.ToLower().Contains(searchString.ToLower()) || c.FieldOfStudy.ToLower().Contains(searchString.ToLower())).ToList();
            }

            return View(courses);
        }
        public IActionResult Details(int courseId) 
        {
            CourseAndRelatedCoursesViewModel courseAndRelatedCourses = new CourseAndRelatedCoursesViewModel();
            courseAndRelatedCourses.Course = _courseRepository.GetById(courseId);

            courseAndRelatedCourses.RelatedCourses = _courseRepository.GetAll().Where(c => c.FieldOfStudy == courseAndRelatedCourses.Course.FieldOfStudy && c.Id != courseAndRelatedCourses.Course.Id).ToList();

            return View(courseAndRelatedCourses);
        }

        public IActionResult About()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

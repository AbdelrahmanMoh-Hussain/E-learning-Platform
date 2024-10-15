using E_learning_Platform.Data;
using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;
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

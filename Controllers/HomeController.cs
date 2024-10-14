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

        public IActionResult Index()
		{
			return View( _courseRepository.GetAll());
		}

		

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

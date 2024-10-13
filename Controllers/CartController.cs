using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace E_learning_Platform.Controllers
{
	[Authorize]
	public class CartController : Controller
	{
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly ICartRepository _cartRepository;
		private readonly IEnrollmentRepository _enrollmentRepository;
        public CartController(SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager,
            ICartRepository cartRepository,
            IEnrollmentRepository enrollmentRepository)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _cartRepository = cartRepository;
            _enrollmentRepository = enrollmentRepository;
        }

        public async Task<IActionResult> Index()
		{
			var userId = await GetSignedInUserIdAsync();
			var cartCourses = _cartRepository.GetUserCartCourses(userId);
			return View(cartCourses);
		}

		[HttpPost]
		public async Task<IActionResult> RemoveCourse(int courseId)
		{
            var userId = await GetSignedInUserIdAsync();
            if (userId == 0)
                return Json(new { success = false });

            var result = await _cartRepository.RemoveCourseFromUserCartAsync(courseId, userId);
            if (result == false)
                return Json(new { success = false });

            return Json(new { success = true });
        }

        [HttpPost]
        public async Task<IActionResult> Enroll(int courseId)
        {
            var userId = await GetSignedInUserIdAsync();
            if(userId == 0)
                return Json(new { success = false });

            var userCourses = _cartRepository.GetUserCartCourses(userId);
            if (userCourses == null)
                return Json(new { success = false });

            var result = _enrollmentRepository.AddEnrollments(userId, userCourses);
            if(result == null)
                return Json(new { success = false });

            return Json(new { success = true });
        }
        private async Task<int> GetSignedInUserIdAsync()
		{
            var username = HttpContext.User.Identity.Name;
            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
                return user.Id;
			return 0;
        }
	}
}

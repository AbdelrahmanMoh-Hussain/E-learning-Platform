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
        public CartController(SignInManager<ApplicationUser> signInManager, 
			UserManager<ApplicationUser> userManager, 
			ICartRepository cartRepository)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _cartRepository = cartRepository;
        }

        public async Task<IActionResult> Index()
		{
			
			
			var userId = await GetSignedInUserIdAsync();
			var cartCourses = _cartRepository.GetUserCartCourses(userId);
			return View(cartCourses);
		}

		[HttpDelete()]
		public async Task<IActionResult> RemoveCourseAsync(int courseId)
		{
            var userId = await GetSignedInUserIdAsync();
			_cartRepository.RemoveCourseFromUserCart(courseId, userId);
			return Ok();
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

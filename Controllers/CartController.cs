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

        public CartController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
		{
			//var userSignedIn = this.User;
			//if (userSignedIn != null)
			//{
			//	userSignedIn.user
			//}
			var username = HttpContext.User.Identity.Name;
			var user = await _userManager.FindByNameAsync(username);
			return View(user.Id);
		}
	}
}

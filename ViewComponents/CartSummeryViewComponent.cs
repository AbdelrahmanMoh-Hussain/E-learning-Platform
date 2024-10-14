using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_learning_Platform.ViewComponents
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private readonly ICartRepository _cartRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        public CartSummaryViewComponent(ICartRepository cartRepository, UserManager<ApplicationUser> userManager)
        {
            _cartRepository = cartRepository;
            _userManager = userManager;
        }
        public IViewComponentResult Invoke()
        {
            
            var username = HttpContext.User.Identity.Name;
            if(username is null)
                return View(0);

            var user = _userManager.FindByNameAsync(username).Result;
            var cartCount = _cartRepository.GetUserCartCourses(user.Id).Count(); // Adjust based on your method
            return View(cartCount);
        }
    }
}

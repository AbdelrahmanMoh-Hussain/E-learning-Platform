using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;
using E_learning_Platform.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Platform.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEnrollmentRepository _enrollmentRepository;

        public UserController(UserManager<ApplicationUser> userManager, IEnrollmentRepository enrollmentRepository)
        {
            _userManager = userManager;
            _enrollmentRepository = enrollmentRepository;
        }

        public IActionResult Index()
        {
            List<UserRoleWithEnrolledCoursesViewModel> modelList = new List<UserRoleWithEnrolledCoursesViewModel>();
            foreach(var user in _userManager.Users)
            {
                modelList.Add(new UserRoleWithEnrolledCoursesViewModel
                {
                    User = user,
                    Role = _userManager.GetRolesAsync(user).Result.FirstOrDefault().ToString(),
                    EnrolledCoursesCount = _enrollmentRepository.GetAllAsync(user.Id).Result.Count()
                });
            }
            return View(modelList);
        }

        public async Task<IActionResult> Delete(int userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
                return Json(new { success = false });
            
            var result = await _userManager.DeleteAsync(user);
            if(!result.Succeeded)
                return Json(new { success = false });

            return Json(new { success = true });

        }
    }
}

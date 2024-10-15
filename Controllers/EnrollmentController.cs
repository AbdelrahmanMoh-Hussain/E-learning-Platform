using E_learning_Platform.Data.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_learning_Platform.Controllers
{
    [Authorize]
    public class EnrollmentController : Controller
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        public async Task<IActionResult> ListUserEnrolledCourses(string userId)
        {
            if (userId is null)
                return View("MyCourses");

            var id = int.Parse(userId);
            if (id == 0)
                return View("MyCourses");

            var courses = await _enrollmentRepository.GetAllAsync(id);
            return View("MyCourses", courses);
        }

        public async Task<IActionResult> AddCourseUserRate(int userId, int courseId, int rate)
        {
            var resultSucceded = await _enrollmentRepository.AddCourseUserRateAsync(userId, courseId, rate);
            if (resultSucceded == false)
                return Json(new { success = false });

            return Json(new { success = true });
        }

        public async Task<IActionResult> CompletePrograss(int userId, int courseId)
        {
            var resultSucceded = await _enrollmentRepository.CompletePrograssAsync(userId, courseId);
            var courses = await _enrollmentRepository.GetAllAsync(userId);
            return View("MyCourses", courses);
        }
    }
}

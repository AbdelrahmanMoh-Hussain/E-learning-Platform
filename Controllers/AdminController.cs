using Microsoft.AspNetCore.Mvc;

namespace E_learning_Platform.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

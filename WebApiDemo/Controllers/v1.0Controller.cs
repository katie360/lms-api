using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    public class v1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

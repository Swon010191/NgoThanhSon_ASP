using Microsoft.AspNetCore.Mvc;

namespace EventRegister.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Resgister()
        {
            ViewBag.Resgister = "Dangky";
            return View();
        }
    }
}

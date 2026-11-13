using Microsoft.AspNetCore.Mvc;

namespace Trial.Controllers
{
    public class EventController : Controller
    {
        [Route("hi")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("dang-ky")]
        public IActionResult Register()
        {
            ViewBag.Name = "sondz";
            ViewBag.Id = "1";
            return View();
        }
        public IActionResult Member()
        {
            List<string> list = new List<string> { "sondz1", "sondz2" };
                ViewData["list"] = list;
            
            return View();
        }
    }
}


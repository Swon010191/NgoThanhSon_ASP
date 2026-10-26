using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using System.Text.Encodings.Web;

namespace Day2.Controllers
{
    public class HomeControllernew : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult xinmoi(string name, int ID = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID la {ID}");
            ViewData["Name"] = name;
            ViewData["ID"] = ID;
            return View();
        }
        public IActionResult cham()
        {
            ViewBag.name = "sondz";
            ViewBag.ID = 1;
            return View();
        }
        public IActionResult component()
        {
            return View();
        }
        public IActionResult partialview()
        {
            ViewBag.name = "sondz";
            ViewBag.ID = 1;
            return View();
        }
        [Route("attributed")]
        public IActionResult attributed()
        {
            ViewBag.name = "sondz";
            ViewBag.ID = 1;
            return View();
        }
    }
}

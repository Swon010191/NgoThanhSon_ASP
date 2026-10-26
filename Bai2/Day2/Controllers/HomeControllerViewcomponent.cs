using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers
{
    [ViewComponent(Name = "HomeControllerViewcomponent")]
    
    public class HomeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.name = "sondz";
            ViewBag.ID = 1;
            return View("component");
        }
    }
}
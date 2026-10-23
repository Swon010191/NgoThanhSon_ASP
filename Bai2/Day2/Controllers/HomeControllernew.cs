using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Day2.Controllers
{
    public class HomeControllernew : Controller
    {
        public string Index()
        {
            return "Xin chao sondz";
        }

        public string xinmoi(string name, int numtimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, Numtimes la {numtimes}");
        }
    }
}

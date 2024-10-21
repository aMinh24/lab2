using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class PathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

public class MessageController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
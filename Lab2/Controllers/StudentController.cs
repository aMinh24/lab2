using Lab2.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    [Authorize(Roles = RoleName.Student)]
    public class StudentController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Mypath()
        {
            return View();
        }

        public IActionResult Mycourse()
        {
            return View();
        }



    }
}

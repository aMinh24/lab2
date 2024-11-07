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

        public IActionResult PathAssessment()
        {
            return View();
        }

        public IActionResult PathAssessmenetResult()
        {
            return View();
        }

        public IActionResult PathDetail()
        {
            return View();
        }

        public IActionResult QuizResult()
        {
            return View();
        }

        public IActionResult QuizResultDetail()
        {
            return View();
        }

        public IActionResult TakeCourse()
        {
            return View();
        }

        public IActionResult TakeLesson()
        {
            return View();
        }

        public IActionResult TakeQuiz()
        {
            return View();
        }



    }
}

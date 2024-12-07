
using Lab2.Data;
using Lab2.Entities;
using Lab2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Controllers
{
    public class BillingController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;

        public BillingController(UserManager<AppUser> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            string userId = _userManager.GetUserId(User);
            Subscription sub = _context.Subscriptions
                .Include(s => s.SubscriptionType)
                .Include(s=>s.Student)
                .FirstOrDefault(s => s.Student.UserId == userId);
            PaymentInformation payInf = _context.PaymentInformations.Find(userId);

            ViewBillModel model = new ViewBillModel
            {
                PaymentInformation = payInf,
                Subscription = sub,
                SubscriptionType = sub.SubscriptionType
            };
            bool n = model.PaymentInformation?.AutoRenew ?? false;
            string t = (model.PaymentInformation?.AutoRenew ?? false) ? "checked" : "";
            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Upgrade()
        {
            return View();
        }
        public IActionResult UpgradeAccount(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/Login");
            }
            string userId = _userManager.GetUserId(User);
            PaymentInformation paymentInformation = _context.PaymentInformations.Find(userId);
            if(paymentInformation == null)
            {
                return RedirectToAction("Payment", "Billing");
            }
            else
            {
                Subscription sub = _context.Subscriptions
                    .Include(s=>s.Student)
                    .First(s => s.Student.UserId == userId);
                
                SubscriptionType subscriptionType = _context.SubscriptionTypes
                    .First(s => s.SubscriptionTypeId == id);
                if(subscriptionType != null)
                {
                    sub.SubscriptionType = subscriptionType;
                    sub.SubscriptionTypeId = id;
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Billing");
                }
            }

            return View();
        }
        public IActionResult Payment()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            string userId = _userManager.GetUserId(User);
            PaymentInformation paymentInformation = _context.PaymentInformations
                .Include(p => p.User)
                .FirstOrDefault(p => p.UserId == userId);
            return View(paymentInformation);
        }
        public IActionResult Invoice()
        {
            return View();
        }
        
        public IActionResult CheckPayment(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/Login");
            }
            // Giả lập kết quả kiểm tra thanh toán
            string userId = _userManager.GetUserId(User);
            PaymentInformation paymentInformation = _context.PaymentInformations.Find(userId);

            if (paymentInformation != null)
            {

                var student = _context.Students.Where(s => s.UserId == userId).FirstOrDefault();
                if (student == null)
                {
                    return Redirect("/Home");
                }

                var course = _context.Courses.Where(c => c.CourseId == id).FirstOrDefault();
                if (course == null)
                {
                    return Redirect("/Home");
                }
                var userCourse = _context.UserCourses
                    .Where(u=>u.UserId == student.StudentId)
                    .Where(u=>u.CourseId == course.CourseId)
                    .FirstOrDefault();
                if (userCourse == null)
                {
                    var newUserCourse = new UserCourse
                        {
                            CourseId = course.CourseId,
                            UserId = student.StudentId,
                            Course = course,
                            Student = student
                        };
                    
                    _context.UserCourses.Add(newUserCourse);
                    _context.SaveChanges();
                }
                return RedirectToAction("TakeLesson", "Student", new { id = id });
            }

            return RedirectToAction("Index", "Payment");
        }


        [HttpPost]
        public IActionResult Payment(PaymentInformation paymentInfo)
        {
            var existingPayment = _context.PaymentInformations
                .FirstOrDefault(p => p.UserId == paymentInfo.UserId);

            if (existingPayment != null)
            {
                existingPayment.CreditNumber = paymentInfo.CreditNumber;
                _context.SaveChanges();

                return RedirectToAction("Payment", "Billing");
            }
            else
            {
                ModelState.AddModelError("", "Payment information not found.");
            }
            return View(paymentInfo);

        }
    }
}

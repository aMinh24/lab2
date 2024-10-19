using Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public InstructorController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var instructors = await _appDbContext.Instructors
                .Include(i => i.AppUser)
                .Include(i => i.PrimaryTopic)
                .Include(i => i.AppUser.CoursesInstructed)
                .ToListAsync();


            return View(instructors);


        }

        public async Task<IActionResult> Profile(int? id)
        {
            if (id == null)
            {
                return BadRequest("Can not solve id");
            }
            var instructors = await _appDbContext.Instructors
                .Where(i => i.InstructorId == id)
                .Include(i => i.AppUser)
                .Include(i => i.PrimaryTopic)
                .Include(i => i.AppUser.CoursesInstructed)
                .FirstOrDefaultAsync();

            if (instructors == null)
            {
                return NotFound();
            }
            return View(instructors);

        }

        public IActionResult MyCourse()
        {
            return View();
        }

        public IActionResult EditCourse()
        {
            return View();
        }
    }
}

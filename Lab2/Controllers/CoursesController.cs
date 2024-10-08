using Lab2.Models;
using Lab2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;

        public CoursesController(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<ActionResult> Index()
        {
            // Eager loading Instructor (AppUser) with the Courses
            var courses = await _context.Courses
                .Include(c => c.Instructor)
                .ToListAsync();


            // Using a ViewModel is highly recommended for better organization and type safety
            var viewModel = courses.Select(c => new CourseViewModel
            {
                CourseId = c.CourseId,
                Title = c.Title,
                InstructorName = c.Instructor?.UserName, // Access UserName from the included Instructor
                // Add other properties as needed
                Description = c.Description,
                Thumbnail = c.Thumbnail,
                // ... other properties
            });



            return View(viewModel);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest("Can not solve id");
            }
            var course = await _context.Courses
                .Include(c => c.Instructor) // Eager loading for the instructor
                .FirstOrDefaultAsync(c => c.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }
        public IActionResult Student()
        {
            return View();
        }
    }
}

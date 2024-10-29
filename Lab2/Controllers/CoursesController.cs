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
                .Include(c=>c.Topic)
                .Include(c=>c.UserCourses)
                .ToListAsync();
            var feedbacks = await _context.FeedBacks
                .ToListAsync();
            
            foreach (var course in courses)
            {
                // Calculate the average rating, handling null values correctly
                course.AverageRating = feedbacks
                    .Where(f =>f.CourseId == course.CourseId)
                    .Where(f => f.Rating.HasValue)
                    .Average(f => (double?)f.Rating) ?? 0; // Defaults to 0 if no ratings exist
            }
            var viewModel = courses.Select(c => new CourseViewModel
            {
                Topic = c.Topic,
                CourseId = c.CourseId,
                Title = c.Title,
                // Add other properties as needed
                Description = c.Description,
                Thumbnail = c.Thumbnail,
                InstructorName = c.Instructor.Name,
                AverageRating = c.AverageRating
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
                .Include(c => c.Chapters)
                .ThenInclude(ch => ch.Lessons)
                .FirstOrDefaultAsync(c => c.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            var feedbacks = await _context.FeedBacks
                .Where(f => f.CourseId == course.CourseId)
                .Where(f => f.Rating.HasValue)
                .OrderByDescending(f => f.Created)
                .Include(f=>f.Student)
                .ThenInclude(s=>s.AppUser)
                .ToListAsync();
            return View(Tuple.Create(course, feedbacks.AsEnumerable()));
        }

        public IActionResult Student()
        {
            return View();
        }

        public async Task<IActionResult> Trailer(int? id)
        {
            if (id == null)
            {
                return BadRequest("Can not solve id");
            }
            var course = await _context.Courses
                .Include(c => c.Instructor) // Eager loading for the instructor
                .Include(c => c.Chapters)
                .ThenInclude(ch => ch.Lessons)
                .FirstOrDefaultAsync(c => c.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }
    }
}

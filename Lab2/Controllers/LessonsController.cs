using Lab2.Models;
using Lab2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Controllers
{
    public class LessonsController : Controller
    {
        private readonly AppDbContext _context;

        public LessonsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet("/Lessons/{id?}")]
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null) 
                return NotFound();

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Review", "Lessons", new { id });
            }

            var lesson = await _context.Lessons.FirstOrDefaultAsync(l => l.LessonId == id);
            if (lesson == null) 
                return NotFound();

            var course = await _context.Courses
                .Include(c => c.Instructor)
                .ThenInclude(i => i.AppUser)
                .SingleOrDefaultAsync(c => c.Chapters.Any(ch => ch.ChapterId == lesson.ChapterId));
    
            if (course == null) 
                return NotFound();

            var viewModel = new LessonViewModel
            {
                LessonName = lesson.Title,
                CourseTitle = course.Title,
                InstructorName = course.Instructor.AppUser.Name,
                InstructorAvatar = course.Instructor.Avatar,
                UrlVideo = lesson.VideoUrl,
                Description = lesson.Description,
                Duration = TimeSpan.FromMinutes(lesson.EstimateTime).ToString(@"hh\:mm")
            };

            return View(viewModel);
        }

        public IActionResult Review(int? id)
        {
            Lesson lesson = _context.Lessons.FirstOrDefault(l => l.LessonId == id);
            Course course = _context.Courses.Include(c => c.Instructor).ThenInclude(i=>i.AppUser).FirstOrDefault(c => c.Chapters.Any(ch => ch.ChapterId == lesson.ChapterId));

            LessonViewModel viewModel = new LessonViewModel
            {
                LessonName = lesson.Title,
                CourseTitle = course.Title,
                InstructorName = course.Instructor.AppUser.Name,
                InstructorAvatar = course.Instructor.Avatar,
                UrlVideo = lesson.VideoUrl,
                Description = lesson.Description,
                Duration = TimeSpan.FromMinutes(lesson.EstimateTime).ToString(@"hh\:mm")
            }; if (lesson == null) return NotFound();
            return View(viewModel);
        }
    }
}

using Lab2.Models;
using Lab2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class LessonsController : Controller
    {
        private readonly AppDbContext _context;

        public LessonsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            Lesson lesson = _context.Lessons.FirstOrDefault(l => l.LessonId == id);
            Course course = _context.Courses.FirstOrDefault(c => c.Chapters.Any(ch => ch.ChapterId == lesson.ChapterId));
            AppUser instructor = _context.Users.FirstOrDefault(u => u.Id == course.InstructorId);
            LessonViewModel viewModel = new LessonViewModel
            {
                CourseTitle = course.Title,
                InstructorName = instructor.UserName,
                Title = lesson.Title,
                UrlVideo = lesson.VideoUrl,
                Description = lesson.Description,
                Duration = TimeSpan.FromMinutes(lesson.EstimateTime).ToString(@"hh\:mm")
            }; if (lesson == null) return NotFound();
            return View(viewModel);
        }
    }
}

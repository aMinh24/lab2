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

        public IActionResult Index(int? id)
        {
            Lesson lesson = _context.Lessons.FirstOrDefault(l => l.LessonId == id);
            Course course = _context.Courses.Include(c=>c.Instructor).FirstOrDefault(c => c.Chapters.Any(ch => ch.ChapterId == lesson.ChapterId));
            LessonViewModel viewModel = new LessonViewModel
            {
                CourseTitle = course.Title,
                InstructorName = course.Instructor.Name,
                Title = lesson.Title,
                UrlVideo = "https://www.youtube.com/embed/o1JIK5W3DRU?si=6jqOuz3OL9dPVxRm",
                Description = lesson.Description,
                Duration = TimeSpan.FromMinutes(lesson.EstimateTime).ToString(@"hh\:mm")
            }; if (lesson == null) return NotFound();
            return View(viewModel);
        }

    }
}

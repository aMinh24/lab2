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
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Review", "Lessons", new { id = id });
            }
            Lesson lesson = _context.Lessons.Include(l => l.Discussions).ThenInclude(d=>d.User).FirstOrDefault(l => l.LessonId == id);
            Course course = _context.Courses.Include(c => c.Instructor).FirstOrDefault(c => c.Chapters.Any(ch => ch.ChapterId == lesson.ChapterId));

            LessonViewModel viewModel = new LessonViewModel
            {
                Id = lesson.LessonId,
                LessonName = lesson.Title,
                CourseTitle = course.Title,
                InstructorName = course.Instructor.Name,
                InstructorAvatar = course.Instructor.Avatar,
                UrlVideo = lesson.VideoUrl,
                Description = lesson.Description,
                Duration = TimeSpan.FromMinutes(lesson.EstimateTime).ToString(@"hh\:mm"),
                Discussions = lesson.Discussions.OrderByDescending(l=>l.CreatedAt).Take(2).ToList(),
            }; if (lesson == null) return NotFound();
            return View(viewModel);
        }
        public IActionResult Review(int? id)
        {
            Lesson lesson = _context.Lessons.FirstOrDefault(l => l.LessonId == id);
            Course course = _context.Courses.Include(c => c.Instructor).FirstOrDefault(c => c.Chapters.Any(ch => ch.ChapterId == lesson.ChapterId));

            LessonViewModel viewModel = new LessonViewModel
            {
                LessonName = lesson.Title,
                CourseTitle = course.Title,
                InstructorName = course.Instructor.Name,
                InstructorAvatar = course.Instructor.Avatar,
                UrlVideo = lesson.VideoUrl,
                Description = lesson.Description,
                Duration = TimeSpan.FromMinutes(lesson.EstimateTime).ToString(@"hh\:mm"),
            }; if (lesson == null) return NotFound();
            return View(viewModel);
        }
    }
}

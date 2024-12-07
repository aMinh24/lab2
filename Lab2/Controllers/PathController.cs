using Lab2.Entities;
using Lab2.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Path = Lab2.Entities.Path;

namespace Lab2.Controllers
{
    public class PathController : Controller
    {
        private readonly IPathService _pathService;
        private readonly IChapterService _chapterService;
        private readonly ICourseService _courseService;
        private readonly ILessonService _lessonService;
        public PathController(IPathService pathService,IChapterService chapterService,ICourseService courseService,ILessonService lessonService)
        {
            _pathService = pathService;
            _chapterService = chapterService;
            _lessonService = lessonService;
            _courseService = courseService;
        }

        public async Task<IActionResult> Index()
        {
            // Lấy dữ liệu Path
            var paths = await _pathService.GetAllWithIncludesAsync(p => p.TypePath);

            // Lấy dữ liệu Course và nhóm theo PathId
            var courses = await _courseService.GetAllWithIncludesAsync(c => c.Path, c => c.Chapters);
            var coursesByPathId = courses.GroupBy(c => c.PathId)
                .ToDictionary(g => g.Key, g => g.ToList());

            // Lấy dữ liệu Chapter và nhóm theo CourseId
            var chapters = await _chapterService.GetAllWithIncludesAsync(ch => ch.Course, ch => ch.Lessons);
            var chaptersByCourseId = chapters.GroupBy(ch => ch.CourseId)
                .ToDictionary(g => g.Key, g => g.ToList());

            // Gắn Lessons vào Chapters trước
            foreach (var chapter in chapters)
            {
                chapter.Lessons = chaptersByCourseId.ContainsKey(chapter.CourseId)
                    ? chaptersByCourseId[chapter.CourseId]
                        .SelectMany(ch => ch.Lessons)
                        .ToList()
                    : new List<Lesson>();
            }

            // Gắn Chapters vào Courses
            foreach (var course in courses)
            {
                course.Chapters = chaptersByCourseId.ContainsKey(course.CourseId)
                    ? chaptersByCourseId[course.CourseId]
                    : new List<Chapter>();
            }

            // Gắn Courses vào Paths
            var pathsWithCourses = paths.Select(path =>
            {
                path.Courses = coursesByPathId.ContainsKey(path.PathId)
                    ? coursesByPathId[path.PathId]
                    : new List<Course>();

                return path;
            }).ToList();
            
            return View(pathsWithCourses);
        }
        

        public async  Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest("Can't resolve id");
            }
            
            // Bước 1: Lấy dữ liệu Paths và TypePath
            var paths = await _pathService.GetAllWithIncludesAsync(p => p.TypePath);

            // Bước 2: Lấy dữ liệu Courses và Instructor (nhóm theo PathId)
            var courses = await _courseService.GetAllWithIncludesAsync(c => c.Instructor);
            var coursesByPathId = courses.GroupBy(c => c.PathId)
                .ToDictionary(g => g.Key, g => g.ToList());

            // Bước 3: Lấy dữ liệu Chapters và nhóm theo CourseId
            var chapters = await _chapterService.GetAllWithIncludesAsync(ch => ch.Course);
            var chaptersByCourseId = chapters.GroupBy(ch => ch.CourseId)
                .ToDictionary(g => g.Key, g => g.ToList());

            // Bước 4: Lấy dữ liệu Lessons và nhóm theo ChapterId
            var lessons = await _lessonService.GetAllWithIncludesAsync(l => l.Chapter);
            var lessonsByChapterId = lessons.GroupBy(l => l.ChapterId)
                .ToDictionary(g => g.Key, g => g.ToList());

// Bước 5: Kết nối dữ liệu theo thứ tự từ trong ra ngoài

// Gắn Lessons vào Chapters
            foreach (var chapter in chapters)
            {
                chapter.Lessons = lessonsByChapterId.ContainsKey(chapter.ChapterId)
                    ? lessonsByChapterId[chapter.ChapterId]
                    : new List<Lesson>();
            }

// Gắn Chapters vào Courses
            foreach (var course in courses)
            {
                course.Chapters = chaptersByCourseId.ContainsKey(course.CourseId)
                    ? chaptersByCourseId[course.CourseId]
                    : new List<Chapter>();
            }

// Gắn Courses vào Paths
            foreach (var path in paths)
            {
                path.Courses = coursesByPathId.ContainsKey(path.PathId)
                    ? coursesByPathId[path.PathId]
                    : new List<Course>();
            }

// Bước 6: Lọc Path cần tìm theo Id
            var pathWithDetails = paths.FirstOrDefault(p => p.PathId == id);

// Trả về View với dữ liệu Path đã đầy đủ
            return View(pathWithDetails);

        }
    }
}

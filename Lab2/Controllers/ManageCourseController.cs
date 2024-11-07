using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab2.Models;
using Lab2.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Lab2.Controllers
{
    [Authorize(Roles = RoleName.Instructor)]
    public class ManageCourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ManageCourseController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ManageCourse
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);

            var courses = await _context.Courses
                .Where(c => c.Instructor.UserId.Equals(userId))
                .Include(c => c.Instructor)
                .ThenInclude(i => i.AppUser)
                .Include(c => c.Platform)
                .Include(c => c.Topic)
                .Include(c => c.Path) // Bao gồm Path để có thể hiển thị tên
                .ToListAsync();

            return View(courses);
        }

        // GET: ManageCourse/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Instructor)
                .Include(c => c.Platform)
                .Include(c => c.Topic)
                .Include(c => c.Path) // Include Path information
                .FirstOrDefaultAsync(m => m.CourseId == id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: ManageCourse/Create
        public IActionResult Create()
        {
            ViewData["PlatformId"] = new SelectList(_context.Platforms, "PlatformId", "Name");
            ViewData["TopicId"] = new SelectList(_context.Topics, "TopicId", "Name");

            // Lấy tên Path để hiển thị trong danh sách chọn
            ViewData["PathId"] = new SelectList(_context.Paths, "PathId", "Name");
            ViewData["Difficulty"] = new SelectList(new List<dynamic>
            {
                new { Value = 0, Text = "Beginner" },
                new { Value = 1, Text = "Intermediate" }
            }, "Value", "Text");
            return View();
        }

        // POST: ManageCourse/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("CourseId,Title,Description,TrailerUrl,TopicId,PlatformId,Thumbnail,PathId,DifficultCourse")]
            Course course)
        {
            var userId = _userManager.GetUserId(User);
            var instructor = await _context.Instructors
                .FirstOrDefaultAsync(i => i.UserId.Equals(userId));

            if (instructor == null)
            {
                return BadRequest("Không phải role để tạo");
            }

            course.InstructorId = instructor.InstructorId;
            course.Date = DateTime.Now;

            _context.Add(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: ManageCourse/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.Include(c => c.Path).FirstOrDefaultAsync(c => c.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            ViewData["PlatformId"] = new SelectList(_context.Platforms, "PlatformId", "Name", course.PlatformId);
            ViewData["TopicId"] = new SelectList(_context.Topics, "TopicId", "Name", course.TopicId);
            ViewData["PathId"] = new SelectList(_context.Paths, "PathId", "Name",course.PathId);
            ViewData["Difficulty"] = new SelectList(new List<dynamic>
            {
                new { Value = 0, Text = "Beginner" },
                new { Value = 1, Text = "Intermediate" }
            }, "Value", "Text", course.DifficultCourse.HasValue ? (int)course.DifficultCourse : 0);

            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,
            [Bind("CourseId,Title,Description,TrailerUrl,InstructorId,TopicId,PlatformId,Thumbnail,Date,PathId,DifficultCourse")]
            Course course)
        {
            if (id != course.CourseId)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);
            var instructor = await _context.Instructors.FirstOrDefaultAsync(i => i.UserId.Equals(userId));
            if (instructor == null)
            {
                return BadRequest("Không phải role để tạo");
            }

            course.InstructorId = instructor.InstructorId;
            try
            {
                _context.Update(course);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseExists(course.CourseId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ManageCourse/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Instructor)
                .Include(c => c.Platform)
                .Include(c => c.Topic)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: ManageCourse/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.CourseId == id);
        }
    }
}
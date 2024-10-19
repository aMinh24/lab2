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
                .Where(c => c.InstructorId.Equals(userId))
                .Include(c => c.Platform)
                .Include(c => c.Topic)
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

            return View();
        }

        // POST: ManageCourse/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseId,Title,Description,TrailerUrl,TopicId,PlatformId,Thumbnail")] Course course)
        {
            // Gán InstructorId và Date trước khi kiểm tra ModelState
            course.InstructorId = _userManager.GetUserId(User);
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

            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            ViewData["InstructorId"] = new SelectList(_context.Users, "Id", "Id", course.InstructorId);
            ViewData["PlatformId"] = new SelectList(_context.Platforms, "PlatformId", "Name", course.PlatformId);
            ViewData["TopicId"] = new SelectList(_context.Topics, "TopicId", "Name", course.TopicId);
            return View(course);
        }

        // POST: ManageCourse/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseId,Title,Description,TrailerUrl,InstructorId,TopicId,PlatformId,Thumbnail,Date")] Course course)
        {
            if (id != course.CourseId)
            {
                return NotFound();
            }

            course.InstructorId = _userManager.GetUserId(User);
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

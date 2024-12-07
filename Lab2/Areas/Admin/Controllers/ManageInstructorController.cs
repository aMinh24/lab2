using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab2.Data;
using Lab2.Entities;
using Microsoft.AspNetCore.Authorization;

namespace Lab2.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleName.Administrator)]

    [Area("Admin")]
    public class ManageInstructorController : Controller
    {
        private readonly AppDbContext _context;

        public ManageInstructorController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ManageInstructor
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Instructors.Include(i => i.AppUser).Include(i => i.PrimaryTopic);
            return View(await appDbContext.ToListAsync());
        }

        // GET: ManageInstructor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructor = await _context.Instructors
                .Include(i => i.AppUser)
                .Include(i => i.PrimaryTopic)
                .FirstOrDefaultAsync(m => m.InstructorId == id);
            if (instructor == null)
            {
                return NotFound();
            }

            return View(instructor);
        }

        // GET: ManageInstructor/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["TopicId"] = new SelectList(_context.Topics, "TopicId", "Name");
            return View();
        }

        // POST: ManageInstructor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InstructorId,UserId,Name,About,LinkFacebook,LinkTwitter,Avatar,TopicId")] Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instructor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", instructor.UserId);
            ViewData["TopicId"] = new SelectList(_context.Topics, "TopicId", "Name", instructor.TopicId);
            return View(instructor);
        }

        // GET: ManageInstructor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructor = await _context.Instructors.FindAsync(id);
            if (instructor == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", instructor.UserId);
            ViewData["TopicId"] = new SelectList(_context.Topics, "TopicId", "Name", instructor.TopicId);
            return View(instructor);
        }

        // POST: ManageInstructor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InstructorId,UserId,Name,About,LinkFacebook,LinkTwitter,Avatar,TopicId")] Instructor instructor)
        {
            if (id != instructor.InstructorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instructor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstructorExists(instructor.InstructorId))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", instructor.UserId);
            ViewData["TopicId"] = new SelectList(_context.Topics, "TopicId", "Name", instructor.TopicId);
            return View(instructor);
        }

        // GET: ManageInstructor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructor = await _context.Instructors
                .Include(i => i.AppUser)
                .Include(i => i.PrimaryTopic)
                .FirstOrDefaultAsync(m => m.InstructorId == id);
            if (instructor == null)
            {
                return NotFound();
            }

            return View(instructor);
        }

        // POST: ManageInstructor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instructor = await _context.Instructors.FindAsync(id);
            if (instructor != null)
            {
                _context.Instructors.Remove(instructor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstructorExists(int id)
        {
            return _context.Instructors.Any(e => e.InstructorId == id);
        }
    }
}

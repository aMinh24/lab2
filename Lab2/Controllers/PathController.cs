using Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Controllers
{
    public class PathController : Controller
    {
        private readonly AppDbContext _context;

        public PathController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var paths = await _context.Paths
                .Include(p=>p.TypePath)
                .Include(p=>p.Courses)
                .ThenInclude(c=>c.Chapters)
                .ThenInclude(ch=>ch.Lessons)
                .ToListAsync();
        
            
            return View(paths);
        }
        

        public async  Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest("Can't resolve id");
            }
            var path = await _context.Paths
                .Include(p => p.TypePath)
                .Include(p => p.Courses)
                .ThenInclude(c => c.Chapters)
                .ThenInclude(ch => ch.Lessons)
                .Include(p => p.Courses)
                .ThenInclude(c => c.Instructor)
                .ThenInclude(i=>i.AppUser)
                .FirstOrDefaultAsync(p => p.PathId == id);

            return View(path);
        }
    }
}

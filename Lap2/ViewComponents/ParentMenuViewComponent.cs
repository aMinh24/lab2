using Lap2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lap2.Component
{
    public class ParentMenuViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public ParentMenuViewComponent(AppDbContext context)
        {
            _context = context;
        }

        [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Any)] // Cache 1 giờ
        public IViewComponentResult Invoke()
        {
            var menuItems = _context.ParentMenus.ToList();
            return View(menuItems);
        }
    }
}

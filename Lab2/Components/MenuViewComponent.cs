using Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

public class MenuViewComponent : ViewComponent
{
    private readonly AppDbContext _context;
    private readonly IMemoryCache _cache;

    public MenuViewComponent(AppDbContext context, IMemoryCache cache)
    {
        _context = context;
        _cache = cache;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var cacheKey = "MenuCache";

        if (!_cache.TryGetValue(cacheKey, out IEnumerable<ParentMenu> menus))
        {
            menus = await _context.ParentMenus
                .Include(pm => pm.Menus)    
                .ToListAsync();

            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(5));

            _cache.Set(cacheKey, menus, cacheEntryOptions);
        }

        return View("Menu", menus);
    }
}
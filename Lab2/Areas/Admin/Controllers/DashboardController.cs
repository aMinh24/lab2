using Lab2.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Areas.Admin.Controllers;

public class DashboardController:Controller
{
    [Authorize(Roles = RoleName.Administrator)]

    [Area("Admin")]
    public IActionResult Index()
    {
        return View();
    }
}
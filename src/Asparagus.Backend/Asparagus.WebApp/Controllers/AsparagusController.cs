using Asparagus.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Asparagus.WebApp.Controllers;

[ApiController]
public class AsparagusController : Controller
{
    private readonly IAsparagusDbContext _db;

    public AsparagusController(IAsparagusDbContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Asparagus.WebApp.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
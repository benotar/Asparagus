using Microsoft.AspNetCore.Mvc;

namespace Asparagus.WebApp.Controllers;

public class MainController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
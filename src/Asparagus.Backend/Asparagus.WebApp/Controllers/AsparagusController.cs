using Asparagus.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Asparagus.WebApp.Controllers;


[ApiController]
[Route("api/[controller]/[action]")]
public class AsparagusController : ControllerBase
{
    private readonly IAsparagusDbContext _db;

    public AsparagusController(IAsparagusDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public string Get()
        => "Hello, World!";
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WeatherController : ControllerBase
{
    private readonly WeatherContext _context;

    public WeatherController(WeatherContext context)
    {
        _context = context;
    }

    [HttpGet("{city}")]
    public async Task<IActionResult> Get(string city)
    {
        var foundRoot = await _context.Roots.Include(w => w.Wind).Include(m => m.Main).Include(c => c.Clouds).Include(w => w.Weather).Include(s => s.Sys).SingleOrDefaultAsync(r => r.Name.ToUpper() == city.ToUpper());
        if (foundRoot == null)
        {
            return NotFound();
        }
        return Ok(foundRoot);
    }

}

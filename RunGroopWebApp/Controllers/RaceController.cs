using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;

namespace RunGroopWebApp.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var races = await _context.Race.ToListAsync();
            return View(races);
        }
    }
}

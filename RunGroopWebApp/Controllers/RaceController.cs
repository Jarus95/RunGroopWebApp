using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Models;

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

        public async Task<ActionResult> Detail(int id)
        {
            Race race =  await _context.Race.Include(i => i.Address).FirstOrDefaultAsync(c => c.Id == id);
            return View(race);
        }
    }
}

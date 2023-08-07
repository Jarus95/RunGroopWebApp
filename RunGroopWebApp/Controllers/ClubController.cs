using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClubController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        {
            List<Club> clubs = await _context.Club.ToListAsync();
            return View(clubs);
        }

        public async Task<ActionResult> Detail(int id)
        {
            Club club = await _context.Club.Include(i=>i.Address).FirstOrDefaultAsyncs(c => c.Id == id);
            return View(club);
        }
    }
}

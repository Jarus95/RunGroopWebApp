﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Detail(int id)
        {
            Club club = _context.Club.Include(i=>i.Address).FirstOrDefault(c => c.Id == id);
            return View(club);
        }
    }
}

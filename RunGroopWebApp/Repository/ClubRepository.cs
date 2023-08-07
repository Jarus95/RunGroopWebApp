using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Repository
{
    public class ClubRepository : IClubRepository
    {
        private readonly ApplicationDbContext _context;

        public ClubRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Club>> GetAll()
        {
            IEnumerable<Club> clubs = await _context.Club.ToListAsync();
            return clubs;
        }

        public async Task<Club> GetDetailById(int id)
        {
            Club club = await _context.Club.Include(i => i.Address).FirstOrDefaultAsync(c => c.Id == id);
            return club;
        }
    }
}

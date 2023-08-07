using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Repository
{
    public class RaceRepository : IRaceRepository
    {
        private readonly ApplicationDbContext _context;

        public RaceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Race>> GetAll()
        {
            IEnumerable<Race> races = await _context.Race.ToListAsync();
            return races;
        }

        public async Task<Race> GetDetailById(int id)
        {
            Race race = await _context.Race.Include(i => i.Address).FirstOrDefaultAsync(c => c.Id == id);
            return race;
        }

    }
}

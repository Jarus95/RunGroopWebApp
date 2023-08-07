using RunGroopWebApp.Models;

namespace RunGroopWebApp.Repository
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();
        Task<Club> GetDetailById(int id);
    }
}

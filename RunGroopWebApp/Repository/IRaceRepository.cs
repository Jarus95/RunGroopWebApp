using RunGroopWebApp.Models;

namespace RunGroopWebApp.Repository
{
    public interface IRaceRepository
    {
        Task<IEnumerable<Race>> GetAll();
        Task<Race> GetDetailById(int id);
    }
}

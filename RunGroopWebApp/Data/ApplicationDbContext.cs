using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Address> Address { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<Race> Race { get; set; }
    }
}

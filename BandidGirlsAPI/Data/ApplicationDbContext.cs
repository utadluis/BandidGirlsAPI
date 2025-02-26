using BandidGirlsAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BandidGirlsAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<MagicalGirls> MagicalGirls { get; set; }
        public DbSet<Historial> Historials { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using WebApplication3.Models.Entities.ACB;

namespace WebApplication3.Data
{
    public class AcbDbContext : DbContext
    {
        public AcbDbContext(DbContextOptions<AcbDbContext> options) : base(options)
        {

        }



        public DbSet<benchConsumption> benchConsumption { get; set; }
        public DbSet<castProcess> castProcess { get; set; }
        public DbSet<BenchId> BenchId { get; set; }



    }
}

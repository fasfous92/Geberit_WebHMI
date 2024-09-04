using Microsoft.EntityFrameworkCore;
using WebApplication3.Models.Entities;
using WebApplication3.Models.Entities.ACB;
using WebApplication3.Models.Entities.Ceratus;

namespace WebApplication3.Data
{
    public class CeratusDbContext : DbContext
    {
        public CeratusDbContext(DbContextOptions<CeratusDbContext> options) : base(options)
        {

        }

        public DbSet<DailyConsumption> DailyConsumption { get; set; }
        public DbSet<ShiftPerformance> ShiftPerfromance { get; set; }

        public DbSet<ShiftId> ShiftId { get; set; }




    }
}

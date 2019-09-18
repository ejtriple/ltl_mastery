using LTLMastery.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace LTLMastery.Web.DataContext
{
    public class LtlMasteryDbContext : DbContext
    {
        public LtlMasteryDbContext(DbContextOptions<LtlMasteryDbContext> options)
            : base(options)
        {
        }

        public DbSet<PotentialShipment> PotentialShipments { get; set; }
        public DbSet<Truck> Trucks { get; set; }
    }
}
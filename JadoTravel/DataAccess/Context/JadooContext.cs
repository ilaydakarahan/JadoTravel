using JadoTravel.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace JadoTravel.DataAccess.Context
{
    public class JadooContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-BFPJH2M;database=DbJadoTravel;integrated security=true;trustServerCertificate=true");
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}

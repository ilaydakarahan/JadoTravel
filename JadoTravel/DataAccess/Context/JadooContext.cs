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
        public DbSet<Company> Companies  { get; set; }
        public DbSet<Feature> Features  { get; set; }
        public DbSet<Step> Steps  { get; set; }
        public DbSet<Subscribe> Subscribes  { get; set; }
        public DbSet<Testimonial> Testimonials  { get; set; }

    }
}

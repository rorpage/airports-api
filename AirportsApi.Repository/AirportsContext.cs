using Microsoft.EntityFrameworkCore;
using AirportsApi.Repository.Entities;
using AirportsApi.Repository.Configurations;

namespace AirportsApi.Repository;

[ExcludeFromCodeCoverage]
public class AirportsContext : DbContext
{
    public AirportsContext(DbContextOptions<AirportsContext> options) : base(options) { }

    public DbSet<Airport> Airports { get; set; }
    public DbSet<Frequency> Frequencies { get; set; }
    public DbSet<Runway> Runways { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AirportConfiguration());
        modelBuilder.ApplyConfiguration(new FrequencyConfiguration());
        modelBuilder.ApplyConfiguration(new RunwayConfiguration());
    }
}

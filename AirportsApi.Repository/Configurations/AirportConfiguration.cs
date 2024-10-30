using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AirportsApi.Repository.Entities;

namespace AirportsApi.Repository.Configurations;

[ExcludeFromCodeCoverage]
public class AirportConfiguration : IEntityTypeConfiguration<Airport>
{
    public void Configure(EntityTypeBuilder<Airport> builder)
    {
        builder.ToTable("airports");

        builder.Property(a => a.Id).IsRequired();

        builder.Property(a => a.Continent).IsRequired(false).HasColumnName("continent");
        builder.Property(a => a.Elevation).IsRequired(false).HasColumnName("elevation_ft");
        builder.Property(a => a.GpsCode).IsRequired(false).HasColumnName("gps_code");
        builder.Property(a => a.HomeLink).IsRequired(false).HasColumnName("home_link");
        builder.Property(a => a.IataCode).IsRequired(false).HasColumnName("iata_code");
        builder.Property(a => a.Identity).IsRequired(false).HasColumnName("ident");
        builder.Property(a => a.IsoCountry).IsRequired(false).HasColumnName("iso_country");
        builder.Property(a => a.IsoRegion).IsRequired(false).HasColumnName("iso_region");
        builder.Property(a => a.Keywords).IsRequired(false).HasColumnName("keywords");
        builder.Property(a => a.Latitude).IsRequired(false).HasColumnName("latitude_deg");
        builder.Property(a => a.LocalCode).IsRequired(false).HasColumnName("local_code");
        builder.Property(a => a.Longitude).IsRequired(false).HasColumnName("longitude_deg");
        builder.Property(a => a.Municipality).IsRequired(false).HasColumnName("municipality");
        builder.Property(a => a.Name).IsRequired(false).HasColumnName("name");
        builder.Property(a => a.ScheduledService).IsRequired(false).HasColumnName("scheduled_service");
        builder.Property(a => a.Type).IsRequired(false).HasColumnName("type");
        builder.Property(a => a.WikipediaLink).IsRequired(false).HasColumnName("wikipedia_link");
    }
}

using AirportsApi.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirportsApi.Repository.Configurations;

[ExcludeFromCodeCoverage]
public class RunwayConfiguration : IEntityTypeConfiguration<Runway>
{
    public void Configure(EntityTypeBuilder<Runway> builder)
    {
        builder.ToTable("runways");

        builder.Property(r => r.Id).IsRequired();

        builder.Property(r => r.AirportId).IsRequired().HasColumnName("airport_ref");
        builder.Property(r => r.AirportIdentity).IsRequired(false).HasColumnName("airport_ident");
        builder.Property(r => r.Closed).IsRequired(false).HasColumnName("closed");
        builder.Property(r => r.HighEndDisplacedThreshold).IsRequired(false).HasColumnName("he_displaced_threshold_ft");
        builder.Property(r => r.HighEndElevation).IsRequired(false).HasColumnName("he_elevation_ft");
        builder.Property(r => r.HighEndHeadingDegreesTrue).IsRequired(false).HasColumnName("he_heading_degT");
        builder.Property(r => r.HighEndIdentification).IsRequired(false).HasColumnName("he_ident");
        builder.Property(r => r.HighEndLatitude).IsRequired(false).HasColumnName("he_latitude_deg");
        builder.Property(r => r.HighEndLongitude).IsRequired(false).HasColumnName("he_longitude_deg");
        builder.Property(r => r.Length).IsRequired(false).HasColumnName("length_ft");
        builder.Property(r => r.Lighted).IsRequired(false).HasColumnName("lighted");
        builder.Property(r => r.LowEndDisplacedThreshold).IsRequired(false).HasColumnName("le_displaced_threshold_ft");
        builder.Property(r => r.LowEndElevation).IsRequired(false).HasColumnName("le_elevation_ft");
        builder.Property(r => r.LowEndHeadingDegreesTrue).IsRequired(false).HasColumnName("le_heading_degT");
        builder.Property(r => r.LowEndIdentification).IsRequired(false).HasColumnName("le_ident");
        builder.Property(r => r.LowEndLatitude).IsRequired(false).HasColumnName("le_latitude_deg");
        builder.Property(r => r.LowEndLongitude).IsRequired(false).HasColumnName("le_longitude_deg");
        builder.Property(r => r.Surface).IsRequired(false).HasColumnName("surface");
        builder.Property(r => r.Width).IsRequired(false).HasColumnName("width_ft");
    }
}

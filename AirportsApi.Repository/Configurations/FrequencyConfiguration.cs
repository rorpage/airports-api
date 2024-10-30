using AirportsApi.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirportsApi.Repository.Configurations;

[ExcludeFromCodeCoverage]
public class FrequencyConfiguration : IEntityTypeConfiguration<Frequency>
{
    public void Configure(EntityTypeBuilder<Frequency> builder)
    {
        builder.ToTable("airport_frequencies");

        builder.Property(f => f.Id).IsRequired();

        builder.Property(f => f.AirportId).IsRequired().HasColumnName("airport_ref");
        builder.Property(f => f.AirportIdentity).IsRequired(false).HasColumnName("airport_ident");
        builder.Property(f => f.Description).IsRequired().HasColumnName("description");
        builder.Property(f => f.Type).IsRequired().HasColumnName("type");
        builder.Property(f => f.Value).IsRequired().HasColumnName("frequency_mhz");
    }
}

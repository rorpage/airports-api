namespace AirportsApi.Repository.Entities;

[ExcludeFromCodeCoverage]
public class Airport
{
    public int Id { get; set; }

    public string? Continent { get; set; }
    public int? Elevation { get; set; }
    public string? GpsCode { get; set; }
    public string? HomeLink { get; set; }
    public string? IataCode { get; set; }
    public string? Identity { get; set; }
    public string? IsoCountry { get; set; }
    public string? IsoRegion { get; set; }
    public string? Keywords { get; set; }
    public decimal? Latitude { get; set; }
    public string? LocalCode { get; set; }
    public decimal? Longitude { get; set; }
    public string? Municipality { get; set; }
    public string? Name { get; set; }
    public string? ScheduledService { get; set; }
    public string? Type { get; set; }
    public string? WikipediaLink { get; set; }

    public ICollection<Frequency> Frequencies { get; } = [];
    public ICollection<Runway> Runways { get; } = [];
}

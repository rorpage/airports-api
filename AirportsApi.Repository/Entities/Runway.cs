namespace AirportsApi.Repository.Entities;

[ExcludeFromCodeCoverage]
public class Runway
{
    public int Id { get; set; }

    public int AirportId { get; set; }
    public string? AirportIdentity { get; set; }
    public bool? Closed { get; set; }
    public int? HighEndDisplacedThreshold { get; set; }
    public int? HighEndElevation { get; set; }
    public int? HighEndHeadingDegreesTrue { get; set; }
    public string? HighEndIdentification { get; set; }
    public decimal? HighEndLatitude { get; set; }
    public decimal? HighEndLongitude { get; set; }
    public int? Length { get; set; }
    public bool? Lighted { get; set; }
    public int? LowEndDisplacedThreshold { get; set; }
    public int? LowEndElevation { get; set; }
    public int? LowEndHeadingDegreesTrue { get; set; }
    public string? LowEndIdentification { get; set; }
    public decimal? LowEndLatitude { get; set; }
    public decimal? LowEndLongitude { get; set; }
    public string? Surface { get; set; }
    public int? Width { get; set; }

    public Airport Airport { get; set; } = null!;
}

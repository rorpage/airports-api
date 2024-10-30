namespace AirportsApi.Repository.Entities;

[ExcludeFromCodeCoverage]
public class Frequency
{
    public int Id { get; set; }

    public int AirportId { get; set; }
    public string? AirportIdentity { get; set; }
    public string? Description { get; set; }
    public string? Type { get; set; }
    public string? Value { get; set; }

    public Airport Airport { get; set; } = null!;
}

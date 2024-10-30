using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;
using AirportsApi.Repository;

const string appName = "Airports API";
const string defaultRoute = "/";

var builder = WebApplication.CreateBuilder(args);

var databaseConnectionString = builder.Configuration.GetConnectionString("AirportsDatabase");
builder.Services.AddDbContext<AirportsContext>(options =>
    options.UseSqlServer(databaseConnectionString)
);

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = appName,
        Description = "Airport data from OurAirports!",
        Version = "v1"
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{appName} v1");
});

var authKeyValue = builder.Configuration.GetValue<string>("AuthKey");

app.Use(async (context, next) =>
{
    if (context.Request.Path.Equals(defaultRoute)) { await next(context); return; }

    var authKey = context.Request.Headers["x-auth-key"];

    if (string.IsNullOrEmpty(authKey) || authKey != authKeyValue)
    {
        context.Response.StatusCode = 401;
        await context.Response.WriteAsync("Invalid auth key");

        return;
    }

    await next(context);
});

app.MapGet(defaultRoute, () =>
{
    return appName;
});

app.MapGet("/api/airports/{id}", (AirportsContext db, string id) =>
{
    var airports = db.Airports
        .Include(a => a.Frequencies)
        .Include(a => a.Runways);

    var parsedId = int.TryParse(id, out var int_id);

    return parsedId
        ? airports.SingleOrDefault(a => a.Id == int_id)
        : airports.SingleOrDefault(a => a.Identity == id);
});

app.MapGet("/api/frequencies/{id}", (AirportsContext db, int id) =>
{
    return db.Frequencies
        .Include(r => r.Airport)
        .SingleOrDefault(r => r.Id == id);
});

app.MapGet("/api/runways/{id}", (AirportsContext db, int id) =>
{
    return db.Runways
        .Include(r => r.Airport)
        .SingleOrDefault(r => r.Id == id);
});

app.Run();

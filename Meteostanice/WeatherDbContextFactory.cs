using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Meteostanice;

public class WeatherDbContextFactory
    : IDesignTimeDbContextFactory<WeatherDbContext>
{
    public WeatherDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<WeatherDbContext>();

        optionsBuilder.UseSqlite("Data Source=meteo.db");

        return new WeatherDbContext(optionsBuilder.Options);
    }
}
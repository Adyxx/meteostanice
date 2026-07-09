using Microsoft.EntityFrameworkCore;

namespace Meteostanice;

public class WeatherDbContext : DbContext
{
    public DbSet<WeatherRecord> WeatherRecords => Set<WeatherRecord>();

    public WeatherDbContext(DbContextOptions<WeatherDbContext> options)
        : base(options)
    {
    }
}
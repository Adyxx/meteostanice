

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;
using System.Text.Json;
using System.Xml.Serialization;

namespace Meteostanice
{
    internal class Program
    {

        static async Task DownloadWeatherAsync(IConfiguration config, WeatherDbContext db)
        {

            string url = config["Station:Url"]
                ?? throw new InvalidOperationException("Station:Url configuration is missing.");

            try
            {
                using HttpClient client = new HttpClient();

                string xml = await client.GetStringAsync(url);

                XmlSerializer serializer = new XmlSerializer(typeof(Wario));

                using StringReader reader = new StringReader(xml);
                Wario data = serializer.Deserialize(reader) as Wario
                    ?? throw new InvalidOperationException("Failed to load XML data from the Station.");


                string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
                {
                    WriteIndented = true
                });


                db.WeatherRecords.Add(new WeatherRecord
                {
                    RetrievedAt = DateTime.UtcNow,
                    JsonData = json,
                    IsOnline = true
                });

                db.SaveChanges();
                Console.WriteLine($"{DateTime.Now}: Data saved.");
                var count = db.WeatherRecords.Count();
                Console.WriteLine($"Records in DB: {count}");

            }
            catch (Exception)
            {
                db.WeatherRecords.Add(new WeatherRecord
                {
                    RetrievedAt = DateTime.UtcNow,
                    JsonData = null,
                    IsOnline = false
                });

                db.SaveChanges();
                Console.WriteLine($"{DateTime.Now}: Station is offline.");
            }

        }


        static async Task Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(
                    "appsettings.json",
                    optional: false,
                    reloadOnChange: true)
                .Build();

            string connectionString = config.GetConnectionString("Default")!;

            var options = new DbContextOptionsBuilder<WeatherDbContext>()
                .UseSqlite(connectionString)
                .Options;

            using var db = new WeatherDbContext(options);

            db.Database.Migrate();

            db.Database.ExecuteSqlRaw("PRAGMA journal_mode=DELETE;");

            while (true)
            {
                await DownloadWeatherAsync(config, db);

                int minutes = config.GetValue<int>("Station:IntervalMinutes");

                await Task.Delay(TimeSpan.FromMinutes(minutes));
                
            }
        }
    }
}





using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Xml.Serialization;

namespace Meteostanice
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            string? url = config["Station:Url"];

            string connectionString = config.GetConnectionString("Default")!;


            var options = new DbContextOptionsBuilder<WeatherDbContext>()
                .UseSqlite(connectionString)
                .Options;

            using var db = new WeatherDbContext(options);


            db.Database.Migrate();

            try
            {
                using HttpClient client = new HttpClient();

                string xml = await client.GetStringAsync(url);

                XmlSerializer serializer = new XmlSerializer(typeof(Wario));

                using StringReader reader = new StringReader(xml);
                Wario data = (Wario)serializer.Deserialize(reader);

             
                string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                //Console.WriteLine(json);

                db.WeatherRecords.Add(new WeatherRecord
                {
                    RetrievedAt = DateTime.UtcNow,
                    JsonData = json,
                    IsOnline = true
                });

                db.SaveChanges();

            }
            catch (Exception ex)
            {
                db.WeatherRecords.Add(new WeatherRecord
                {
                    RetrievedAt = DateTime.UtcNow,
                    JsonData = null,
                    IsOnline = false
                });

                db.SaveChanges(); 
                
                Console.WriteLine("ERROR: Station is offline.");
            
            }

        }
    }
}




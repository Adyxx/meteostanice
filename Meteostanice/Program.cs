

using Microsoft.Extensions.Configuration;

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

            try
            {
                using HttpClient client = new HttpClient();

                string xml = await client.GetStringAsync(url);

                Console.WriteLine(xml);

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Station is offline.");
            
            }

        }
    }
}






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

            try
            {
                using HttpClient client = new HttpClient();

                string xml = await client.GetStringAsync(url);

                //Console.WriteLine(xml);


                XmlSerializer serializer = new XmlSerializer(typeof(Wario));

                using StringReader reader = new StringReader(xml);
                Wario data = (Wario)serializer.Deserialize(reader);

             
                string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                Console.WriteLine(json);

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Station is offline.");
            
            }

        }
    }
}




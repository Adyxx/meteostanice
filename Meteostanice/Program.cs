

namespace Meteostanice
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            string url = "https://pastebin.com/raw/PMQueqDV";

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




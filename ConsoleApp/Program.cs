using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            swaggerClient client = new("https://localhost:44367", new HttpClient()); // quick and dirty way to setup HttpClient

            var records = await client.WeatherForecastAsync();


            foreach (var r in records)
            {
                Console.WriteLine($"{r.Date}: {r.Summary}");
            }
        }
    }
}

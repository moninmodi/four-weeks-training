using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AsynAwaitWeatherForcasting
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string city = "Vadodara, India";
            string apiKey = "f058c35ac23b0300860f12ef099b94f4";
            string city1 = "Jamnagar, India";
            // Call the method to fetch weather data
            // Display the weather data with city name
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";
            string url1 = $"https://api.openweathermap.org/data/2.5/weather?q={city1}&appid={apiKey}";
            String JSON = await FetchWeatherDataAsync(url);
            if(!string.IsNullOrEmpty(JSON) )
            {

                WeatherData wd = JsonSerializer.Deserialize<WeatherData>(JSON);
            }
        }

        // Call OpenWeatherMap API to fetch weather data https://openweathermap.org/api
        // Create a C# object from the JSON response
        // Replace Task<string> with the C# object Task<WeatherData>
        static async Task<string> FetchWeatherDataAsync(string url)
        {
            // Fetch web page content asynchronously using HttpClient
            using(HttpClient client = new HttpClient())
            {
                string response;
                try
                {
                    HttpResponseMessage message = await client.GetAsync(url);
                    if (message.IsSuccessStatusCode)
                    {
                        response = await message.Content.ReadAsStringAsync();
                        return response;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                return String.Empty;  
            }
        }
        public class WeatherData
        {
            public string Name { get; set; }
            public MainData Main { get; set; }
        }
    }
}
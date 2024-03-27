using System.Text.Json;

namespace Hiemstra;

class Program
{
    static void Main(string[] args)
    {
        HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5009");
        for (var i = 0; i < 2000; i++)
        {
            
            var result = client.GetAsync("weatherforecast").Result;
            if (result.IsSuccessStatusCode)
            {
                Stream fs = result.Content.ReadAsStream();
                var options = new JsonSerializerOptions();
                options.PropertyNameCaseInsensitive = true;
                var ser = JsonSerializer.Deserialize<WeatherForecast[]>(fs, options);

                System.Console.WriteLine(i);
                foreach (var item in ser)
                {
                   //System.Console.WriteLine(item.TemperatureF);
                }
                // StreamReader rdr = new StreamReader(fs);
                // string data = rdr.ReadToEnd();
                // System.Console.WriteLine(data);
            }
        }
    }
}

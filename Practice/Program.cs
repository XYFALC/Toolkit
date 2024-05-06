using Newtonsoft.Json;
using Practice;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;


namespace Program
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

        }

        public async Task<string> GetRequest()
        {
            APIRequest request = new APIRequest();
            string result = await request.ApiCall("https://api.open-meteo.com/v1/forecast?latitude=50.9071,50.9071&longitude=6.0272,6.0272&hourly=temperature_2m&timezone=auto");
            List<WeatherData> weatherDataList = JsonConvert.DeserializeObject<List<WeatherData>>(result);

            DateTime currentTime = DateTime.Now;
            string formattedDate = currentTime.ToString("yyyy-MM-dd");
            Console.WriteLine("Current Date: " + formattedDate);

            List<string> TodaysWeatherTime = new List<string>();
            List<double> TodaysWeatherTemp = new List<double>();

            foreach (var weatherData in weatherDataList)
            {
                for (int i = 0; i < weatherData.Hourly.Time.Count; i++)
                {
                    var time = weatherData.Hourly.Time[i];
                    if (time.Contains(formattedDate)){
                        DateTime dateTime = DateTime.Parse(time);
                        time = dateTime.ToString("HH:mm");
                        TodaysWeatherTime.Add(time);
                    }
                }
                for (int i = 0; i < TodaysWeatherTime.Count; i++)
                {
                    var temperature = weatherData.Hourly.Temperature_2m[i];
                    TodaysWeatherTemp.Add(temperature);               
                }
            }

            for (int i = 0; i < TodaysWeatherTime.Count; i++)
            {
                Console.WriteLine($"{TodaysWeatherTime[i]} {TodaysWeatherTemp[i]}");
            }

            return result;
        }
    }
}
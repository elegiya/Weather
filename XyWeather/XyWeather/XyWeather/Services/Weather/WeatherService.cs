using Newtonsoft.Json;
using System.Threading.Tasks;
using XyWeather.Models;
using XyWeather.Services.Networking;

namespace XyWeather.Services.Weather
{
    /// <summary>
    /// Sevice for getting data on clint side (a weather using REST client).
    /// </summary>
    public class WeatherService : IWeatherService
    {
        private readonly IRestClient _restClient;

        private const string WEATHER_URI = "http://api.openweathermap.org/data/2.5/weather?";
        private const string KEY = "2eef7c2b42a4f388bbf8b28be5fe4dd2";

        public WeatherService()
        {
            _restClient = new RestClient();
        }

        /// <summary>
        /// Gets the all the weather data in C# classes.
        /// </summary>
        /// <param name="city">City for search</param>
        /// <returns>Class with parsed weather data.</returns>
        public async Task<WeatherToday> GetWeatherAsync(string city)
        {
            var response = await _restClient.GetAsync(GetFullUrlForCity(city));
            return JsonConvert.DeserializeObject<WeatherToday>(response);
        }

        private string GetFullUrlForCity(string cityName)
        {
            return $"{WEATHER_URI}q={cityName}&APPID={KEY}&units=metric&cnt=1";
        }
    }
}

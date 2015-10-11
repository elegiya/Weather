using System;
using XyWeather.Services.Networking;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XyWeather.Models;

namespace XyWeather.Services.Weather
{
    public class WeatherService : IWeatherService
    {
        const string GetTemperatureUri = "http://api.openweathermap.org/data/2.5/forecast?q=Oslo";
        readonly IRestClient _restClient = new RestClient();

        public async Task<double> GetTemperatureAsync(string city)
        {
            var response = await _restClient.GetAsync(GetTemperatureUri);
            var weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            return weatherResponse.main.temp - 273;
        }
    }
}

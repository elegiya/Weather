using System;
using System.Collections.Generic;
using XyWeather.Services.Networking;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XyWeather.Models;

namespace XyWeather.Services.Weather
{
    public class WeatherService : IWeatherService
    {
        private const string GetTemperatureUri =
            "http://api.openweathermap.org/data/2.5/forecast?q=";

        private const string key = "";

        private readonly IRestClient _restClient = new RestClient();

        public async Task<double> GetTemperatureAsync(string city)
        {
            var response = await _restClient.GetAsync(GetFullUrlForCity(city));
            var weatherResponse = JsonConvert.DeserializeObject<Main>(response);
            return weatherResponse.temp - 273;
        }

        public string GetFullUrlForCity(string cityName)
        {
            return $"{GetTemperatureUri}{cityName}{key}";
        }
    }
}

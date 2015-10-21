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
        private readonly IRestClient _restClient;

        //private const string TEMPERATURE_URI = "http://api.openweathermap.org/data/2.5/forecast?q=";

        private const string KEY = "2eef7c2b42a4f388bbf8b28be5fe4dd2";

        public WeatherService()
        {
            _restClient = new RestClient();
        }

        public async Task<WeatherToday> GetTemperatureAsync(string city)
        {
            var response = await _restClient.GetAsync(GetFullUrlForCity(city));
            return JsonConvert.DeserializeObject<WeatherToday>(response);
        }

        private string GetFullUrlForCity(string cityName)
        {
            return $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&APPID={KEY}&units=metric&cnt=1";
        }
    }
}

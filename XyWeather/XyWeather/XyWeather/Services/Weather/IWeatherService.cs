using System;
using System.Threading.Tasks;
using XyWeather.Models;

namespace XyWeather.Services.Weather
{
    public interface IWeatherService
    {
        Task<WeatherToday> GetTemperatureAsync(string city);
    }

}


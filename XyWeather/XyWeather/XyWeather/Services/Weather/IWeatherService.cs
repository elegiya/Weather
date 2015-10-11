using System;
using System.Threading.Tasks;

namespace XyWeather.Services.Weather
{
    public interface IWeatherService
    {
        Task<double> GetTemperatureAsync(string city);
    }

}


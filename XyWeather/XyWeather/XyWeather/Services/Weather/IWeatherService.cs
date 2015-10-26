using System.Threading.Tasks;
using XyWeather.Models;

namespace XyWeather.Services.Weather
{
    /// <summary>
    /// Sevice for getting a weather using REST client.
    /// </summary>
    public interface IWeatherService
    {
        /// <summary>
        /// Gets the all the weather data in C# classes.
        /// </summary>
        /// <param name="city">City for search</param>
        /// <returns>Class with parsed weather data.</returns>
        Task<WeatherToday> GetWeatherAsync(string city);
    }

}


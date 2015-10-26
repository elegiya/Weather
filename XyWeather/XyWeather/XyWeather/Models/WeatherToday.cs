using System.Collections.Generic;

namespace XyWeather.Models
{
    public class WeatherToday
    {
        public List<Weather> weather { get; set; }
        public Main main { get; set; }
        public Coord coord { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public Sys sys { get; set; }
    }
}

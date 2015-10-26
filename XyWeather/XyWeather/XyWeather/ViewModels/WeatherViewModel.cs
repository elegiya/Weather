using System;
using System.Windows.Input;
using Xamarin.Forms;
using XyWeather.Services.Weather;

namespace XyWeather.ViewModels
{
    /// <summary>
    /// ViewModel to get a weather today.
    /// </summary>
    public class WeatherViewModel : BaseViewModel
    {
        private readonly WeatherService _weatherService;
        private string _city;

        private readonly string _date;
        private string _clouds;
        private string _temperature;
        private string _description;
        private string _humidity;
        private string _wind;

        public WeatherViewModel()
        {
            _weatherService = new WeatherService();
            _date = DateTime.Today.ToString();

            this.ChooseCityCommand = new Command(MakeSearchByName);
        }

        /// <summary>
        /// Gets or sets the city for search.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the date for search.
        /// </summary>
        public string Date
        {
            get { return _date; }
        }

        /// <summary>
        /// Gets or sets clouds in City for Date.
        /// </summary>
        public string Clouds
        {
            get { return _clouds; }
            set
            {
                if (_clouds != value)
                {
                    _clouds = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets temperature in City for Date.
        /// </summary>
        public string Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets additional information about weather in City for Date.
        /// </summary>
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets humidity in City for Date.
        /// </summary>
        public string Humidity
        {
            get { return _humidity; }
            set
            {
                if (_humidity != value)
                {
                    _humidity = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets wind in City for Date.
        /// </summary>
        public string Wind
        {
            get { return _wind; }
            set
            {
                if (_wind != value)
                {
                    _wind = value;
                    OnPropertyChanged();
                }
            }
        }
        
        /// <summary>
        /// Raised when city is chosen.
        /// </summary>
        public ICommand ChooseCityCommand { get; private set; }

        private async void MakeSearchByName()
        {
            var weatherResult = await _weatherService.GetWeatherAsync(City);

            Clouds = weatherResult.clouds.all.ToString();
            Temperature = weatherResult.main.temp.ToString();
            Description = weatherResult?.weather[0].description;
            Humidity = weatherResult.main.humidity.ToString();
            Wind = weatherResult.wind.speed.ToString();
        }
    }
}

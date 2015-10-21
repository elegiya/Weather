using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XyWeather.Services.Weather;

namespace XyWeather.ViewModels
{
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

        public string Date
        {
            get { return _date; }
        }

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
        
        public ICommand ChooseCityCommand { get; private set; }

        private async void MakeSearchByName()
        {
            var weatherResult = await _weatherService.GetTemperatureAsync(City);

            Clouds = weatherResult.clouds.all.ToString();
            Temperature = weatherResult.main.temp.ToString();
            Description = weatherResult?.weather[0].description;
            Humidity = weatherResult.main.humidity.ToString();
            Wind = weatherResult.wind.speed.ToString();
        }
    }
}

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
        private string _temperature;

        public WeatherViewModel()
        {
            _weatherService=new WeatherService();
            this.ChooseCityCommand=new Command(MakeSearchByName);
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

        public ICommand ChooseCityCommand { get; private set; }
        
        private async void MakeSearchByName()
        {
            var temperature = await _weatherService.GetTemperatureAsync(City);
            Temperature = temperature.ToString();
        }
    }
}

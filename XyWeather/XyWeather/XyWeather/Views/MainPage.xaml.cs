using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XyWeather.Services.Weather;
using XyWeather.ViewModels;

namespace XyWeather.Views
{
    public partial class MainPage : ContentPage
    {
        readonly IWeatherService _weatherService = new WeatherService();

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new WeatherViewModel();//this.Navigation);

            //var temperature = await _weatherService.GetTemperatureAsync("oslo");
            //temperatureLabel.Text = temperature.ToString();
        }
    }
}


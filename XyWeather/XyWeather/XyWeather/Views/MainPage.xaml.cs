using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XyWeather.Services.Weather;

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
            var temperature = await _weatherService.GetTemperatureAsync(string.Empty);
            temperatureLabel.Text = temperature.ToString();
        }
    }
}


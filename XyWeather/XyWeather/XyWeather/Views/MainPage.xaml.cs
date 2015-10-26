
using Xamarin.Forms;
using XyWeather.ViewModels;

namespace XyWeather.Views
{
    /// <summary>
    /// Entry application point.
    /// </summary>
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Start the application.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new WeatherViewModel();
        }
    }
}


using AppWeather.Models.ViewModels;

namespace AppWeather;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BindingContext = new WeatherInfoPageViewModel();
	}
}


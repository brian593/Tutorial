using EjemploAPI.ViewModels;

namespace EjemploAPI.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext=viewModel;
	}
}
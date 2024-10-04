using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using EjemploAPI.Services;
using EjemploAPI.ViewModels;
using EjemploAPI.Views;

namespace EjemploAPI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddTransient<IApiServices, ApiServices>();
      	// Registro del ViewModel
        builder.Services.AddTransient<MainPageViewModel>();
        // Registro de la página
        builder.Services.AddTransient<MainPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

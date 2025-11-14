using Microsoft.Extensions.Logging;
using ProjetoFInalTiago.Services;
using ProjetoFInalTiago.ViewModels;
using ProjetoFInalTiago.Views;

namespace ProjetoFInalTiago;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        
        // Views
        builder.Services.AddSingleton<Login>();
        builder.Services.AddSingleton<Registro>();
        builder.Services.AddSingleton<Listagem>();
        
        // ViewModels
        builder.Services.AddTransient<LoginViewModel>();
        builder.Services.AddTransient<RegistroViewModel>();
        builder.Services.AddTransient<ListagemViewModel>();

        // Services
        builder.Services.AddSingleton<IUsuarioService, UsuarioService>();
        builder.Services.AddSingleton<IClimaService, ClimaService>();
        builder.Services.AddSingleton<IWeatherService, WeatherService>();
        
        return builder.Build();
    }
}
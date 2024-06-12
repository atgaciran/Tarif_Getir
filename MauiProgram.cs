using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;
using TarifGetir.Services;
using TarifGetir.ViewModels;
using TarifGetir.Views;

namespace TarifGetir
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<YiyecekService>();
            builder.Services.AddTransient<YiyecekListelemeViewModel>();
            builder.Services.AddTransient<YiyecekDetayViewModel>();

            builder.Services.AddSingleton<YiyecekListesiPage>();
            builder.Services.AddTransient<TarifDetay>();

            return builder.Build();
        }
    }
}

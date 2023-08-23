using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace LoginUIKit;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Arimo-Bold.ttf", "ArimoBold");
                fonts.AddFont("Arimo-Regular.ttf", "ArimoRegular");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
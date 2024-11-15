using Microsoft.Extensions.Logging;

namespace CadastroEvento
{
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
                    fonts.AddFont("RobotoSlab-Black.ttf", "RobotoSlab-Black");
                    fonts.AddFont("RobotoSlab-Regular.ttf", "RobotoSlab-Regular");
                    fonts.AddFont("RobotoSlab-Thin.ttf", "RobotoSlab-Thin");
                    fonts.AddFont("PoiretOne-Regular.ttf", "PoiretOne-Regular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

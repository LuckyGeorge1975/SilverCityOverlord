using CommunityToolkit.Maui;
using CommunityToolkit.Maui.ApplicationModel;
using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Maui.Media;
using CommunityToolkit.Maui.Storage;
using Microsoft.Extensions.Logging;
using tdc.maui.silvercity.ViewModels;
using tdc.maui.silvercity.Views;

namespace tdc.maui.silvercity
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitMarkup()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            RegisterViewsAndViewModels(builder.Services);
            RegisterEssentials(builder.Services);

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        static void RegisterViewsAndViewModels(in IServiceCollection services)
        {
            services.AddTransient<MainPage, MainViewModel>();
            services.AddTransient<GamePage, GameViewModel>();
        }

        static void RegisterEssentials(in IServiceCollection services)
        {
            services.AddSingleton<IDeviceDisplay>(DeviceDisplay.Current);
            services.AddSingleton<IDeviceInfo>(DeviceInfo.Current);
            services.AddSingleton<IBadge>(Badge.Default);
        }
    }
}

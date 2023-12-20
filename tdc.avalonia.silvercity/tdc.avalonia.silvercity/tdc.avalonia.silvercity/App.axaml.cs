using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using MediatR;
using tdc.avalonia.silvercity.ViewModels;
using tdc.avalonia.silvercity.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ReactiveUI;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using Splat.Microsoft.Extensions.Logging;
using Splat.ReactiveUIExtensions;
using tdc.avalonia.silvercity.ViewModels.Menu;
using tdc.avalonia.silvercity.Views.Menu;

namespace tdc.avalonia.silvercity;

public partial class App : Application
{
    //public IServiceProvider Container { get; private set; }
    private IHost _host = null!;
    
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        _host = Host
            .CreateDefaultBuilder()
            .ConfigureServices((_, services) =>
            {
                services.UseMicrosoftDependencyResolver();
                RegisterViewsAndViewModels(services);

                var resolver = Locator.CurrentMutable;
                resolver.InitializeSplat();
                resolver.InitializeReactiveUI();
                services.AddMediatR(cfg => {
                    cfg.RegisterServicesFromAssembly(typeof(App).Assembly);
                });
            })
            .Build();

        //Container = _host.Services;
        //Container.UseMicrosoftDependencyResolver();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = Locator.Current.GetService<MainWindow>();
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = Locator.Current.GetService<MainView>();
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void RegisterViewsAndViewModels(IServiceCollection services)
    {
        services.AddTransient<MainWindow>();
        services.AddTransient<MainView>();
        services.AddSingleton<MainViewModel>();
        services.AddSingleton<StartViewModel>();
        services.AddSingleton<ChooseCharacterViewModel>();
    }
}
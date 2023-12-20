using Avalonia.Controls;
using Microsoft.Extensions.DependencyInjection;
using Splat;
using tdc.avalonia.silvercity.ViewModels;

namespace tdc.avalonia.silvercity.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = Locator.Current.GetService<MainViewModel>();
    }
}
using Avalonia.Controls;
using Splat;
using tdc.avalonia.silvercity.ViewModels;

namespace tdc.avalonia.silvercity.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        DataContext = Locator.Current.GetService<MainViewModel>();
    }
}
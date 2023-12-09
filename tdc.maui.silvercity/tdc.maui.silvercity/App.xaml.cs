using tdc.maui.silvercity.ViewModels;
using tdc.maui.silvercity.Views;

namespace tdc.maui.silvercity
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage(new MainViewModel());
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(GamePage), typeof(GamePage));
        }
    }
}

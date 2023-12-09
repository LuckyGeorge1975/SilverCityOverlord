using CommunityToolkit.Mvvm.Input;
using tdc.maui.silvercity.Game.Players;
using tdc.maui.silvercity.ViewModels;
using tdc.maui.silvercity.Views;

namespace tdc.maui.silvercity
{
    public partial class MainPage : BasePage<MainViewModel>
    {
        public MainPage(MainViewModel mainViewModel)
            : base(mainViewModel)
        {
            InitializeComponent();
        }
    }

}

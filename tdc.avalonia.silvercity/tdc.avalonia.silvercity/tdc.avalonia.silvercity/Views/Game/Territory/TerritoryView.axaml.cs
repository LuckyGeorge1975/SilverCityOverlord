using Avalonia.Controls;
using Avalonia.Input;
using tdc.avalonia.silvercity.ViewModels.Game;

namespace tdc.avalonia.silvercity.Views.Game.Territory
{
    public partial class TerritoryView : UserControl
    {
        public TerritoryView()
        {
            InitializeComponent();
        }

        private void RootPanel_OnPointerPressed(object? sender, PointerPressedEventArgs e)
        {
            if (sender is Panel panel && panel.DataContext is TerritoryViewModel vm)
            {
                vm.IsSelected = !vm.IsSelected;
            }
        }
    }
}

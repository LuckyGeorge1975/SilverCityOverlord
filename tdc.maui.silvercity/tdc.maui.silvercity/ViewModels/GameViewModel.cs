using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace tdc.maui.silvercity.ViewModels;

public partial class GameViewModel(Game.Game game) : BaseViewModel
{
    private readonly Game.Game _game = game;

    [RelayCommand]
    void ShowPlayer()
    {
    }

    [RelayCommand]
    void ShowGang()
    {

    }

    [RelayCommand]
    void ShowRegion()
    {

    }
}
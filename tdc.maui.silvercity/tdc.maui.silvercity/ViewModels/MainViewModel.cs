using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using tdc.maui.silvercity.Game.Players;
using tdc.maui.silvercity.Views;

namespace tdc.maui.silvercity.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [RelayCommand]
    public async Task CreateNewGame()
    {
        var game = new Game.Game("No Name", "No Description");
        game.AddPlayer(new HumanPlayer("Dummy Human"));

        var vm = new GameViewModel(game);

        Application.Current?.MainPage?.Navigation.PushModalAsync(new GamePage(vm));
    }
}
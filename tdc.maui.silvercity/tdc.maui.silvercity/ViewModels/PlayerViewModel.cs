using tdc.maui.silvercity.Game.Interfaces;

namespace tdc.maui.silvercity.ViewModels;

public class PlayerViewModel(IPlayer player)
{
    private readonly IPlayer _player = player;
}
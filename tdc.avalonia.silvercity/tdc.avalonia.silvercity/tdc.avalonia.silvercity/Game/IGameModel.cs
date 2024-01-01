using System.Collections.Generic;
using tdc.avalonia.silvercity.Game.Player;
using tdc.avalonia.silvercity.Game.Territory;

namespace tdc.avalonia.silvercity.Game;

public interface IGameModel
{
    List<ITerritoryModel> Territories { get; }
    int Width { get; }
    int Height { get; }
    List<IPlayerModel> Players { get; }
    IPlayerModel? CurrentPlayer { get; set; }
    int CurrentTurn { get; }
}
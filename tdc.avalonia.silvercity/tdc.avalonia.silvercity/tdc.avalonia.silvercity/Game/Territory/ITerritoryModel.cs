using System.Collections.Generic;
using Avalonia;
using tdc.avalonia.silvercity.Game.Base;
using tdc.avalonia.silvercity.Game.Player;

namespace tdc.avalonia.silvercity.Game.Territory;

public interface ITerritoryModel
{
    string? Name { get; set; }
    string? Description { get; set; }
    string? ImagePath { get; set; }
    TerritoryType Type { get; }
    Position Position { get; }
    Dictionary<IPlayerModel, int> PlayerInfluencePoints { get; }
    int InfluencePointsToReachControl { get; }
}
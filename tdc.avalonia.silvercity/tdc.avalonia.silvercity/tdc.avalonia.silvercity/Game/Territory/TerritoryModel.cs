using System.Collections.Generic;
using Avalonia;
using tdc.avalonia.silvercity.Game.Base;
using tdc.avalonia.silvercity.Game.Player;

namespace tdc.avalonia.silvercity.Game.Territory;

public class TerritoryModel(TerritoryType type, Position position) : ITerritoryModel
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? ImagePath { get; set; }

    public TerritoryType Type => type;

    public Position Position => position;

    public Dictionary<IPlayerModel, int> PlayerInfluencePoints { get; } = new();

    public int InfluencePointsToReachControl { get; } = 100;
}
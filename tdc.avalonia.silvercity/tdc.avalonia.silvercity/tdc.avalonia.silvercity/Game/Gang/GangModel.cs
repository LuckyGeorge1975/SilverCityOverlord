using Avalonia;
using tdc.avalonia.silvercity.Game.Base;

namespace tdc.avalonia.silvercity.Game.Gang;

public class GangModel : IGangModel
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;

    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Stealth { get; set; }
    public int Extortion { get; set; }
    public int Theft { get; set; }
    public int Influence { get; set; }

    public Position Position { get; set; }
}
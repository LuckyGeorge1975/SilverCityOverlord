using tdc.avalonia.silvercity.Game.Base;

namespace tdc.avalonia.silvercity.Game.Gang;

public interface IGangModel
{
    string Name { get; set; }
    string Description { get; set; }
    string ImagePath { get; set; }
    int Attack { get; set; }
    int Defense { get; set; }
    int Stealth { get; set; }
    int Extortion { get; set; }
    int Theft { get; set; }
    int Influence { get; set; }
    Position Position { get; set; }
}
using System.Collections.Generic;
using Avalonia.Media;
using tdc.avalonia.silvercity.Game.Character;
using tdc.avalonia.silvercity.Game.Gang;

namespace tdc.avalonia.silvercity.Game.Player;

public interface IPlayerModel
{
    string Name { get; set; }
    string Description { get; set; }
    ICharacterModel Character { get; set; }
    List<IGangModel> Gangs { get; set; }
    Color Color { get; set; }
}
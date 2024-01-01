using System.Collections.Generic;
using Avalonia.Media;
using tdc.avalonia.silvercity.Game.Character;
using tdc.avalonia.silvercity.Game.Gang;

namespace tdc.avalonia.silvercity.Game.Player;

public class PlayerModel(
    string name,
    string description,
    ICharacterModel character,
    List<IGangModel> gangs,
    Color color) : IPlayerModel
{
    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Description
    {
        get => description;
        set => description = value;
    }

    public ICharacterModel Character
    {
        get => character;
        set => character = value;
    }

    public List<IGangModel> Gangs
    {
        get => gangs;
        set => gangs = value;
    }

    public Color Color
    {
        get => color;
        set => color = value;
    }
}
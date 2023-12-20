using System.Collections.ObjectModel;
using tdc.avalonia.silvercity.Game.Character;
using tdc.avalonia.silvercity.ViewModels.Game;
using tdc.avalonia.silvercity.ViewModels.Menu;

namespace tdc.avalonia.silvercity.ViewModels.DesignTime;

public static class DesignData
{
    public static ChooseCharacterViewModel ChooseCharacterViewModel { get; } = new ChooseCharacterViewModel(null!)
    {
        CurrentCharacter = new CharacterViewModel(CharacterGenerator.GenerateCharacter(null!))
    };

    public static CharacterViewModel CharacterViewModel { get; } = new CharacterViewModel(CharacterGenerator.GenerateCharacter(null!))
    {

    };
}
using Avalonia.Media.Imaging;
using System.Reflection;
using tdc.avalonia.silvercity.Game.Character;

namespace tdc.avalonia.silvercity.ViewModels.Game;

public class CharacterViewModel(ICharacterModel character) : ViewModelBase
{
    public string Name => character.Name;
    public string Description => character.Description;
    public int Strength => character.Strength;
    public int Agility => character.Agility;
    public int Intelligence => character.Intelligence;
    public int Charisma => character.Charisma;
    public int Tech => character.Tech;

    public Bitmap? Image {
        get
        {
            if(!string.IsNullOrEmpty(character.ImagePath))
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceStream = assembly.GetManifestResourceStream(character.ImagePath);
                if (resourceStream != null)
                    return new Bitmap(resourceStream);
            } 
            return null;
        }
    }
}
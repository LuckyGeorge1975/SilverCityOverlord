namespace tdc.avalonia.silvercity.Game.Character;

public class CharacterModel : ICharacterModel
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;

    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
    public int Charisma { get; set; }
    public int Tech { get; set; }
}
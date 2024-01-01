namespace tdc.avalonia.silvercity.Game.Character;

public interface ICharacterModel
{
    string Name { get; set; }
    string Description { get; set; }
    string ImagePath { get; set; }
    int Strength { get; set; }
    int Agility { get; set; }
    int Intelligence { get; set; }
    int Charisma { get; set; }
    int Tech { get; set; }
}
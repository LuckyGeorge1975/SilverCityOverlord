using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace tdc.avalonia.silvercity.Game.Character;

public class CharacterGenerator
{
    public const string MaleIdentifier = "-male-";
    public const string FemaleIdentifier = "-female-";

    public const string SmartIdentifier = "-smart-";
    public const string StrongIdentifier = "-strong-";
    public const string TechIdentifier = "-tech-";
    public const string StylishIdentifier = "-stylish-";
    public const string ScienceIdentifier = "-science-";

    public const int MaxCharacters = 20;
    private static readonly List<ICharacterModel> _characters = new();

    public static ICharacterModel GenerateCharacter(string resourceName)
    {
        if(String.IsNullOrEmpty(resourceName))
            resourceName = GetBossResourceName().First();
        var character = new CharacterModel
        {
            Name = "Test Character",
            Description = "This is a test character.",
            ImagePath = resourceName,
            Strength = 10,
            Agility = 10,
            Intelligence = 10,
            Charisma = 10,
            Tech = 10
        };
        return character;
    }

    public static List<ICharacterModel> GetCharacters()
    {
        if (_characters.Count == 0)
        {
            var resourceNames = GetBossResourceName();
            for (var i = 0; i < MaxCharacters && i < resourceNames.Count; i++)
            {
                _characters.Add(GenerateCharacter(resourceNames[i]));
            }
        }

        return _characters;
    }

    private static List<string> GetBossResourceName()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceNames = assembly.GetManifestResourceNames().Where(rn => rn.Contains("Characters"));
        return resourceNames.ToList();
    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using tdc.avalonia.silvercity.Game.Gang;

namespace tdc.avalonia.silvercity.Game.Character;

public class GangGenerator
{
    public const string MaleIdentifier = "-male-";
    public const string FemaleIdentifier = "-female-";

    public const int MaxGangs = 18;
    private static readonly List<IGangModel> _gangs = new();

    public static IGangModel GenerateGang(string resourceName)
    {
        if(String.IsNullOrEmpty(resourceName))
            resourceName = GetGangResourceName().First();
        var gang = new GangModel
        {
            Name = String.Empty,
            Description = String.Empty,
            ImagePath = String.Empty,
            Attack = 0,
            Defense = 0,
            Stealth = 0,
            Extortion = 0,
            Theft = 0,
            Influence = 0
        };
        return gang;
    }

    public static List<IGangModel> GetGangs()
    {
        if (_gangs.Count == 0)
        {
            var resourceNames = GetGangResourceName();
            for (var i = 0; i < MaxGangs && i < resourceNames.Count; i++)
            {
                _gangs.Add(GenerateGang(resourceNames[i]));
            }
        }

        return _gangs;
    }

    private static List<string> GetGangResourceName()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceNames = assembly.GetManifestResourceNames().Where(rn => rn.Contains("Gangs.Leader"));
        return resourceNames.ToList();
    }
    
}
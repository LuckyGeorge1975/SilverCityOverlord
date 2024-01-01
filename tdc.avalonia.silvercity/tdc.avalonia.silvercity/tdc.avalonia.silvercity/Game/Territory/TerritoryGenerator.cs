using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Avalonia;
using tdc.avalonia.silvercity.Game.Base;

namespace tdc.avalonia.silvercity.Game.Territory;

public class TerritoryGenerator
{
    private static readonly Random random = new Random();

    public static List<ITerritoryModel> GenerateTerritories(int width, int height)
    {
        var territories = new List<ITerritoryModel>();
        var resourceNames = GetResourceNames();

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                var territoryType = GetRandomTerritoryType();
                var territoryResourceName = resourceNames.FirstOrDefault(rn => rn.Contains(territoryType.ToString().ToLower()));
                territories.Add(new TerritoryModel(GetRandomTerritoryType(), new Position(x,y)){ImagePath = territoryResourceName});
            }
        }

        return territories;
    }

    public static string GenerateRandomTerritoryGrid(int width, int height)
    {
        StringBuilder gridBuilder = new StringBuilder();

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                var territory = GetRandomTerritoryType();
                var shortString = "";
                switch (territory)
                {
                    case TerritoryType.LIGHT_RESIDENTIAL:
                        shortString = "sr";
                        break;
                    case TerritoryType.DENSE_RESIDENTIAL:
                        shortString = "dr";
                        break;
                    case TerritoryType.LIGHT_COMMERCIAL:
                        shortString = "sc";
                        break;
                    case TerritoryType.DENSE_COMMERCIAL:
                        shortString = "dc";
                        break;
                    case TerritoryType.INDUSTRIAL:
                        shortString = "i";
                        break;
                    case TerritoryType.GOVERNMENT:
                        shortString = "g";
                        break;
                    case TerritoryType.RESEARCH:
                        shortString = "r";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                gridBuilder.Append(shortString);
                gridBuilder.Append(",");
            }
        }

        return gridBuilder.ToString();
    }

    private static List<string> GetResourceNames()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceNames = assembly.GetManifestResourceNames().Where(rn => rn.Contains("Territories.Images"));
        return resourceNames.ToList();
    }

    private static TerritoryType GetRandomTerritoryType()
    {
        var values = Enum.GetValues(typeof(TerritoryType));
        return (TerritoryType)(values.GetValue(random.Next(values.Length)) ?? throw new InvalidOperationException());
    }
}
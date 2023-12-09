using tdc.maui.silvercity.Game.Interfaces;

namespace tdc.maui.silvercity.Game.Regions;

public class DummyRegion : IRegion
{
    private static int _id;

    private int _density;

    private int _defense;

    private int _minimumIntelligenceForBribe;

    private int _minimumSkillForSteal;

    private int _minimumCharismaForPolitics;

    private int _researchBonus;

    private int _influenceBonus;

    public static int Id => _id;

    public int Density => _density;

    public int Defense => _defense;

    public int MinimumIntelligenceForBribe => _minimumIntelligenceForBribe;

    public int MinimumSkillForSteal => _minimumSkillForSteal;

    public int MinimumCharismaForPolitics => _minimumCharismaForPolitics;

    public int ResearchBonus => _researchBonus;

    public int InfluenceBonus => _influenceBonus;

    public Image Image => new()
    {
        Source = ImageSource.FromFile("regions\\research.jpg")
    };

    public DummyRegion()
    {
        _id += 1;
        Initialize();
    }

    public void Initialize()
    {
        _density = 1;
        _defense = 1;
        _minimumIntelligenceForBribe = 1;
        _minimumCharismaForPolitics = 1;
        _minimumSkillForSteal = 1;
        _researchBonus = 1;
        _influenceBonus = 1;
        _researchBonus = 1;
    }
}
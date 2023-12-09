namespace tdc.maui.silvercity.Game.Interfaces;

public interface IRegion
{
    int Density { get; }
    int Defense { get; }
    int MinimumIntelligenceForBribe { get; }
    int MinimumSkillForSteal { get; }
    int MinimumCharismaForPolitics { get; }
    int ResearchBonus { get; }
    int InfluenceBonus { get; }
    Image Image { get; }
    void Initialize();
}
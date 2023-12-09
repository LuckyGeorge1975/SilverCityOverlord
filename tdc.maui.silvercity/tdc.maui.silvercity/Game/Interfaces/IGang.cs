namespace tdc.maui.silvercity.Game.Interfaces
{
    public interface IGang
    {
        string Name { get; }
        string Description { get; }
        int Level { get; }
        int TechLevel { get; }
        int Attack { get; }
        int Defense { get; }
        int Speed { get; }
        int Intelligence { get; }
        int Charisma { get; }
        int Skill { get; }
        Image Image { get; }
    }
}
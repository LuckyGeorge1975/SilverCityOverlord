namespace tdc.maui.silvercity.Game.Interfaces
{
    public interface IPlayer
    {
        string Name { get; }
        List<IGang> Gangs { get; }
        Image Image { get; }
    }
}
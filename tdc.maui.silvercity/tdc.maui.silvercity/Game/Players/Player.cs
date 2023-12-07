using tdc.maui.silvercity.Game.Interfaces;

namespace tdc.maui.silvercity.Game.Players
{
    public class Player: IPlayer
    {
        private readonly string _name;
        private readonly List<IGang> _gangList = [];

        public string Name { get { return _name; } }

        public Image Image = new()
        {
            Source = ImageSource.FromFile("player\\genericmale.jpg")
        };

        public List<IGang> Gangs { get { return _gangList; } }

        public Player()
        {
            _name = string.Empty;
        }
        public Player(string name)
        {
            _name = name;
        }
    }
}

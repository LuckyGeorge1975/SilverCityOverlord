using tdc.maui.silvercity.Game.Interfaces;

namespace tdc.maui.silvercity.Game.Players
{
    public class HumanPlayer: IPlayer
    {
        private static int _id;
        private readonly string _name;
        private readonly List<IGang> _gangList = [];

        public string Name => _name;

        public Image Image => new()
        {
            Source = ImageSource.FromFile("player\\genericmale.jpg")
        };

        public List<IGang> Gangs => _gangList;

        public HumanPlayer()
        {
            _id += 1;
            _name = $"HumanPlayer {_id}";
        }
        public HumanPlayer(string name) : 
            this()
        {
            _name = name;
        }
    }
}

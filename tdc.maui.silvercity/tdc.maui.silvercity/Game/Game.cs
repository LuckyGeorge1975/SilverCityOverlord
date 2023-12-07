using tdc.maui.silvercity.Game.Interfaces;

namespace tdc.maui.silvercity.Game
{
    public class Game
    {
        private static int _id;
        private readonly string _name;
        private readonly string _description;
        private readonly List<IPlayer> _players = [];

        public Game(string name, string description)
        {
            _id += 1;
            _name = name;
            _description = description;
        }

        public static int Id { get => _id; }
        public string Name { get => _name; }
        public string Description { get => _description;}
        public List<IPlayer> Players { get => _players; }

        public void AddPlayer(IPlayer player)
        {
            ArgumentNullException.ThrowIfNull(player);
            _players.Add(player);
        }
    }
}

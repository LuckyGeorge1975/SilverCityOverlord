using tdc.maui.silvercity.Game.Interfaces;
using tdc.maui.silvercity.Game.Regions;

namespace tdc.maui.silvercity.Game
{
    public class Game
    {
        private static int _id;
        private readonly string _name;
        private readonly string _description;
        private readonly List<IPlayer> _players = [];
        private readonly List<IRegion> _regions = [];

        public Game(string name, string description)
        {
            _id += 1;
            _name = name;
            _description = description;
            Initialize();
        }

        private void Initialize()
        {
            for(var i=0;i<16;i++)
                _regions.Add(new DummyRegion());
        }

        public static int Id => _id;
        public string Name => _name;
        public string Description => _description;
        public List<IPlayer> Players => _players;
        public List<IRegion> Regions => _regions;

        public void AddPlayer(IPlayer player)
        {
            ArgumentNullException.ThrowIfNull(player);
            _players.Add(player);
        }
    }
}

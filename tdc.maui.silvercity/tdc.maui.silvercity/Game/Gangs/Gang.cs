using tdc.maui.silvercity.Game.Interfaces;

namespace tdc.maui.silvercity.Game.Gangs
{
    public class Gang : IGang
    {
        private static int _id;
        private readonly string _name;
        private protected string _description;

        private int _level;
        private int _techLevel;
        private int _attack;
        private int _defense;
        private int _speed;
        private int _intelligence;
        private int _charisma;
        private int _skill;

        public string Name => _name;
        public string Description => _description;
        public int Level => _level;
        public int TechLevel => _techLevel;
        public int Attack => _attack;
        public int Defense => _defense;
        public int Speed => _speed;
        public int Intelligence => _intelligence;
        public int Charisma => _charisma;
        public int Skill => _skill;

        public Image Image => new()
        {
            Source = ImageSource.FromFile("gangs\\genericgang.jpg")
        };

        public Gang()
        {
            _id += 1;
            _name = $"Gang {_id}";
            _description = String.Empty;
            InitializeStartValues();
        }
        public Gang(string name) : this()
        {
            _name = name;
        }

        private void InitializeStartValues()
        {
            if (String.IsNullOrEmpty(_description))
                _description = "No Description";

            _level = 1;
            _techLevel = 1;
            _attack = 1;
            _defense = 1;
            _speed = 1;
            _intelligence = 1;
            _charisma = 1;
            _skill = 1;
        }
    }
}

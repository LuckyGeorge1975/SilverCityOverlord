using tdc.maui.silvercity.Game.Interfaces;

namespace tdc.maui.silvercity.Game.Gangs
{
    public class Gang : IGang
    {
        private readonly string _name;
        private readonly string _description;

        private int _level;
        private int _techLevel;
        private int _attack;
        private int _defense;
        private int _speed;
        private int _intelligence;
        private int _charisma;
        private int _skill;

        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public int Level { get => _level; }
        public int TechLevel { get => _techLevel; }
        public int Attack { get => _attack; }
        public int Defense { get => _defense; }
        public int Speed { get => _speed; }
        public int Intelligence { get => _intelligence; }
        public int Charisma { get => _charisma; }
        public int Skill { get => _skill; }

        public Image Image = new()
        {
            Source = ImageSource.FromFile("gangs\\genericgang.jpg")
        };

        public Gang()
        {
            _name = string.Empty;
            _description = string.Empty;
        }
        public Gang(string name)
        {
            _name = name;
            _description = string.Empty;
        }

    }
}

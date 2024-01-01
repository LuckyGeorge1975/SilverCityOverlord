using tdc.avalonia.silvercity.Game.Character;
using tdc.avalonia.silvercity.Game.Territory;

namespace tdc.avalonia.silvercity.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GenerateCharacters_Test()
        {
            var characters = CharacterGenerator.GetCharacters();
            Assert.That(characters.Count, Is.EqualTo(CharacterGenerator.MaxCharacters));
        }

        [Test]
        public void GenerateGangs_Test()
        {
            var gangs = GangGenerator.GetGangs();
            Assert.That(gangs.Count, Is.EqualTo(GangGenerator.MaxGangs));
        }

        [Test]
        public void GenerateTerritoriesAsStringList_Test()
        {
            var territories = TerritoryGenerator.GenerateRandomTerritoryGrid(8,8);
            Assert.That(territories, Is.Not.Empty);
        }
    }
}
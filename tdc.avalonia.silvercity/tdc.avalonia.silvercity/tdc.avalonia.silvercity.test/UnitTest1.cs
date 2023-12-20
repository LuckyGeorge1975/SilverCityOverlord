using tdc.avalonia.silvercity.Game.Character;

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
            Assert.That(CharacterGenerator.MaxCharacters, Is.EqualTo(characters.Count));
        }
    }
}
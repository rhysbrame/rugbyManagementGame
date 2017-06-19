using NUnit.Framework;
using RM17.Models;

namespace RugbyTests
{
    [TestFixture()]
    public class TestPlayer
    {
        private Player IndividualPlayer;

        [SetUp] 
        public void SetUp()
        {
            new Player { PlayerName = "Rhys Patchell", PlayerPosition = 10, PlayerSkill = 14 };
            // IndividualPlayer = new Player("Rhys Patchell", 10, 14);
        }

        [Test()]
        public void TestPlayerNameIsSet()
        {
            Assert.AreEqual("Rhys Patchell", IndividualPlayer.PlayerName);
        }
    }
}
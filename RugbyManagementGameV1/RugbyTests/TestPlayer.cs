using NUnit.Framework;
using RugbyManagementGameV1.Models;

namespace RugbyTests
{
    [TestFixture()]
    public class TestPlayer
    {
        private Player IndividualPlayer;

        [SetUp] 
        public void SetUp()
        {
            IndividualPlayer = new Player("Rhys Patchell", 10, 14);
        }

        [Test()]
        public void TestPlayerNameIsSet()
        {
            Assert.AreEqual("Rhys Patchell", IndividualPlayer.PlayerClassName);
        }

		[Test()]
		public void TestPlayerNameChange()
		{
            /*
             * NO VALUE IN THIS TEST
             * READONLY PROPERTIES DONT COMPILE SO CANT BE TESTED
             * TRUST MICROSOFT
             */
            IndividualPlayer.PlayerClassName = "Rhys";
			Assert.AreEqual("Rhys", IndividualPlayer.PlayerClassName);
		}

		[Test()]
		public void TestPlayerPositionIsSet()
		{
			Assert.AreEqual(10, IndividualPlayer.PlayerClassPosition);
		}

        [Test()]
		public void TestPlayerSkillIsSet()
		{
			Assert.AreEqual( 14, IndividualPlayer.PlayerClassSkill);
		}
    }
}

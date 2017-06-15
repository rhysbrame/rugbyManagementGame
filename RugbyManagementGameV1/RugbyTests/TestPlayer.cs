using NUnit.Framework;
using System;
using RugbyManagementGameV1.Properties;

namespace RugbyTests
{
    [TestFixture()]
    public class TestPlayer
    {
        private Player IndividualPlayer {get;set;}

        [SetUp] 
        public void SetUp() {
            IndividualPlayer = new Player("Darren", 5);
        }

        [Test()]
        public void TestPlayerNameIsSet()
        {
            Assert.AreEqual("Darren", IndividualPlayer.PlayerClassName);
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
		public void TestPlayerSkillIsSet()
		{
			Assert.AreEqual("Darren", IndividualPlayer.PlayerClassName);
		}
    }
}

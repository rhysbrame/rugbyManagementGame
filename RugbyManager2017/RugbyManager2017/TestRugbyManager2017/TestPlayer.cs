using System;
using NUnit.Framework;

namespace TestRugbyManager2017
{
	[TestFixture()]
	public class TestPlayer
	{
		private Player IndividualPlayer;

		[SetUp]
		public void SetUp()
		{
            IndividualPlayer = new Player
            {
                PlayerName = "Stephen Jones",
                PlayerSkill = 2,
                PlayerPosition = 13
            };
		}

		[Test()]
		public void TestPlayerNameIsSet()
		{
			Assert.AreEqual("Rhys Patchell", IndividualPlayer.PlayerName);
		}

		[Test()]
		public void TestPlayerNameChange()
		{
			/*
             * NO VALUE IN THIS TEST
             * READONLY PROPERTIES DONT COMPILE SO CANT BE TESTED
             * TRUST MICROSOFT
             */
			IndividualPlayer.PlayerName = "Rhys";
			Assert.AreEqual("Rhys", IndividualPlayer.PlayerName);
		}

		[Test()]
		public void TestPlayerPositionIsSet()
		{
			Assert.AreEqual(10, IndividualPlayer.PlayerPosition);
		}

		[Test()]
		public void TestPlayerSkillIsSet()
		{
			Assert.AreEqual(14, IndividualPlayer.PlayerSkill);
		}
	}
}

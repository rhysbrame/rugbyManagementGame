using System;
using NUnit.Framework;
using RugbyManagementGameV1.Models;

namespace RugbyTests
{
    [TestFixture()]
    public class TestTeam
    {
        private Team IndividualTeam;
        private Player IndividualPlayer;

        [SetUp]
        public void SetUp()
        {
            IndividualTeam = new Team("Tolouse", 225);
            IndividualPlayer = new Player("Gareth Thomas", 14);
        }

        [Test()]
        public void TestPlayerNameIsSet()
        {
            Assert.AreEqual("Tolouse", IndividualTeam.TeamClassName);
        }

		[Test()]
		public void TestPlayerSkillIsSet()
		{
            Assert.AreEqual(225, IndividualTeam.TeamClassSkill);

		}

        [Test()]
        public void TestTeamSheetEmpty()
        {
            Assert.AreEqual( 0, IndividualTeam.TeamSheetCount());
        }

        [Test()]
        public void TestAddPlayer()
        {
            IndividualTeam.AddPlayer(IndividualPlayer);
            Assert.AreEqual( 1, IndividualTeam.TeamSheetCount());
        }

		[Test()]
		public void TestAddTwoPlayers()
		{
			IndividualTeam.AddPlayer(IndividualPlayer);
            IndividualTeam.AddPlayer(IndividualPlayer);
			Assert.AreEqual(2, IndividualTeam.TeamSheetCount());
		}

		[Test()]
		public void TestTeamSheetFull()
		{
            for (int i = 0; i < 15; i++)
            {
                IndividualTeam.AddPlayer(IndividualPlayer);
            }
			Assert.AreEqual( true , IndividualTeam.TeamSheetFull());
            Assert.AreEqual( 15, IndividualTeam.TeamSheetCount());
		}

        [Test()]
        public void TestCalculateTeamSkill()
        {
            
            for (int i = 0; i < IndividualTeam.teamSheet.Length; i++)
			{
				IndividualTeam.AddPlayer(IndividualPlayer);
			}
			Assert.AreEqual( 210, IndividualTeam.CalculateTeamSkill());
        }

	}
}

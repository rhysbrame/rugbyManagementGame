using NUnit.Framework;
using System;
using RugbyManagementGameV1.Models;

namespace RugbyTests
{
    [TestFixture()]
    public class GameTest
    {
        private Game IndividualGame;
        private Team HomeTeam;
        private Team AwayTeam;

        [SetUp()]
        public void SetUp()
        {
            HomeTeam = new Team("Tolouse", 150);
            AwayTeam = new Team("Saracens", 300);
            IndividualGame = new Game(HomeTeam, AwayTeam);
        }

		[Test()]
		public void TestGameHasTeams()
		{
            Assert.AreEqual("Saracens", AwayTeam.TeamClassName);
		}

        [Test()]
        public void TestCalculateWinnerRange()
        {          
            Assert.AreEqual( 0.33, IndividualGame.CalculateWinnerRange()); 
        }
    }
}

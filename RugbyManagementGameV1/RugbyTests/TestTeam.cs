using NUnit.Framework;
using RugbyManagementGameV1.Models;

namespace RugbyTests
{
    [TestFixture()]
    public class TestTeam
    {
        private Team IndividualTeam;

        [SetUp]
        public void SetUp()
        {
            IndividualTeam = new Team("Tolouse", 225);
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
    }
}

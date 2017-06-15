using NUnit.Framework;
using RugbyManagementGameV1.Models;

namespace RugbyTests
{
    [TestFixture()]
    public class TestCompetition
    {
		private Competition IndividualCompetition;

		[SetUp]
		public void SetUp()
		{
			IndividualCompetition = new Competition("Pro 12", "League");
		}

        [Test()]
        public void TestCompetitionNameIsSet()
        {
            Assert.AreEqual("Pro 12", IndividualCompetition.CompetitionClassName);
        }

		[Test()]
		public void TestCompetitionLayoutIsSet()
		{
            Assert.AreEqual("League", IndividualCompetition.CompetitionClassLayout);
		}
    }
}

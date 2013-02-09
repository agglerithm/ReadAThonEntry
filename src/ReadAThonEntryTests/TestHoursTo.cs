namespace TimekeeperTests
{
    using System;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;
    using ReadAThonEntry;
    using TimeKeeper;
    using Cjr.Common.Testing;

    [TestFixture]
    public class TestHoursTo
    {
        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {

        }
        [SetUp]
        public void SetUpForEachTest()
        {

        }

        [Test]
        public void can_find_time_difference()
        {
            var start = DateTime.Parse("11/1/2012 4:15 PM");
            var end = DateTime.Parse("11/1/2012 6:30 PM");

            var hours = start.HoursTo(end);

            hours.ShouldEqual((decimal) 3.25);
        }

        [TearDown]
        public void TearDownForEachTest()
        {

        }

        [TestFixtureTearDown]
        public void TearDownAfterAllTests()
        {

        }
    }
}

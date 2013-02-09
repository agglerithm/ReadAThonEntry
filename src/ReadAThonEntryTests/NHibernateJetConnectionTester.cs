

namespace ReadAThonEntryTests
{
    using CJR.Persistence;
    using NUnit.Framework; 

    [TestFixture]
    public class NHibernateJetConnectionTester
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
        public void can_connect()
        {
            var src = new CjrSessionSource ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=entries.mdb", "ReadAThonEntry", true, false);

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



using System.Configuration;
using CJR.Persistence.configs;
using NHibernate.Context;
using NHibernate.Linq;
using ReadAThonEntry.Core.DTOs;

namespace ReadAThonEntryTests
{
    using CJR.Persistence;
    using NUnit.Framework; 

    [TestFixture]
    public class NHibernateJetConnectionTester
    {
        private CjrSessionSource<StudentDto, ThreadStaticSessionContext> _src;

        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {
   _src = new CjrSessionSource<StudentDto, 
                ThreadStaticSessionContext>("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bin\\entries.mdb", false);
           
        }
        [SetUp]
        public void SetUpForEachTest()
        {

        }

        [Test]
        public void can_connect()
        {
          var sess = _src.SessionFactory.OpenSession();
            sess.Query<StudentDto>();
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

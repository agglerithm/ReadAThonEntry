using CJR.Common;
using CJR.Persistence;
using Microsoft.Practices.ServiceLocation;
using NUnit.Framework;
using ReadAThonEntryTests.configs;

namespace ReadAThonEntryTests
{
    [SetUpFixture]
    public class SetUpFixture
    {
        private ISessionWrapper _dbSession;

        [SetUp]
        public void setup()
        { 
            var container = IoC.Initialize();
            ServiceLocator.SetLocatorProvider(() => new StructureMapServiceLocator(container));

            _dbSession = ServiceLocator.Current.GetInstance<ISessionWrapper>();
            _dbSession.BindToCurrentContext(); 
        }

        [TearDown]
        public void teardown()
        {
            _dbSession.UnbindFromCurrentContext(null);
        }
    }
}
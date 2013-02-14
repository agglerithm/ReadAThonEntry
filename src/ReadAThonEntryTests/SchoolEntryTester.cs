

namespace ReadAThonEntryTests
{
    using Microsoft.Practices.ServiceLocation;
    using NUnit.Framework;
    using ReadAThonEntry.Configs;
    using ReadAThonEntry.Core.Repositories;
    using ReadAThonEntry.Modules;
    using ReadAThonEntry.Services;
    using ReadAThonEntry.ViewModels;
    using Cjr.Common.Testing;
    [TestFixture]
    public class SchoolEntryTester
    {
        private IStudentProcessingService _sut;
        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {
            StructureMapBootstrapper.Execute();
            _sut = ServiceLocator.Current.GetInstance<IStudentProcessingService>();
        }
        [SetUp]
        public void SetUpForEachTest()
        {

        }

        [Test]
        public void should_enter_school_if_school_unknown()
        {
            var student = new StudentPrototype()
                              {
                                  FirstName = "Bob",
                                  LastName = "Cobb",
                                  School = "Transylvania High",
                                  CreateNewSchool = true,
                                  AmountFromEnvelope = "23.33",
                                  AmountFromWebsite = "0",
                                  Teacher = "Mr. Teach",
                                  MinutesRead = "33",
                                  PagesRead = "44",
                                  ReadingGoal = "100",
                                  EnvelopeNumber = "343"
                              };

            _sut.ValidateAndInsert(student);
            var schoolRepo = ServiceLocator.Current.GetInstance<ISchoolRepository>();
            var school = schoolRepo.Find(s => s.Name == "Transylvania High");

            school.ShouldNotBeNull();

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

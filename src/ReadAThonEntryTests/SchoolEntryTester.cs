

using CJR.Common;
using ReadAThonEntryMvc.Models;
using ReadAThonEntryMvc.Services;
using ReadAThonEntryTests.configs;

namespace ReadAThonEntryTests
{
    using Microsoft.Practices.ServiceLocation;
    using NUnit.Framework; 
    using ReadAThonEntry.Core.Repositories;
    using Cjr.Common.Testing;

    [TestFixture]
    public class SchoolEntryTester
    {
        private IStudentProcessingService _sut;
        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {
            _sut = ServiceLocator.Current.GetInstance<IStudentProcessingService>();
        }
        [SetUp]
        public void SetUpForEachTest()
        {

        }

        [Test]
        public void should_enter_student()
        {
            var helper = ServiceLocator.Current.GetInstance<IStudentMappingHelper>();

            var studentRepo = ServiceLocator.Current.GetInstance<IStudentRepository>();
            var studentDto = studentRepo.Find(s => s.LastName == "Cobb");
            if (studentDto != null)
                studentRepo.Delete(studentDto);
            var student = new StudentPrototype()
                              {
                                  FirstName = "Bob",
                                  LastName = "Cobb",
                                  SchoolName = "Transylvania High" ,
                                  SchoolId = 1,
                                  CreateNewSchool = false,
                                  AmountFromEnvelope = "23.33",
                                  AmountFromWebsite = "0",
                                  FundraisingGoal = "0",
                                  Teacher =  25,
                                  MinutesRead = "33",
                                  PagesRead = "44",
                                  ReadingGoal = "100",
                                  EnvelopeNumber = "343"
                              };
            
            helper.LoadPrototype(student);
            _sut.ValidateAndInsert(student, helper);

            studentDto.ShouldNotBeNull();
            studentDto.TeacherId.ShouldEqual(0);
            studentDto.SchoolName.ShouldBeNull();

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

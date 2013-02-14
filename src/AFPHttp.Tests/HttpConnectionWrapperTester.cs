

namespace AFPHttp.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;
    using Test.Common;

    [TestFixture]
    public class HttpConnectionWrapperTester
    {
        private IHttpConnectionWrapper _sut;
        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {
            _sut = new HttpConnectionWrapper();
        }
        [SetUp]
        public void SetUpForEachTest()
        {

        }

        [Test]
        public void can_extract_host()
        {
            var host = _sut.ExtractHost("http://www.yahoo.com?search=nope");
            host.ShouldEqual("http://www.yahoo.com");
        }

        [Test]
        public void can_get_initial_response()
        {
            var resp = _sut.GetInitialResponse("http://www.yahoo.com");

            resp.ResponsePath.ShouldEqual("http://www.yahoo.com/");

            resp.ResponseBuffer.ShouldNotBeNull();
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

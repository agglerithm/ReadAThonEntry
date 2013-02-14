namespace AFPHttp.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AFPST.Common.Extensions;
    using AFPHttp;
    using NUnit.Framework;
    using Test.Common;

    [TestFixture]
    public class SessionCookieContainerTester
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
        public void can_store_sessions()
        {
            var cookies = new List<string>
                              {
                                  "urn:novell:nidp:cluster:member:id=~03~05~7Dbc~00~17~16rrs~0F; Path=/nidp",
                                  "UrnNovellNidpClusterMemberId=~03~05~7Dbc~00~17~16rrs~0F; Path=/nidp",
                                  "JSESSIONID=58DA1BDDCA579C0185CC36EC11F2D533; Path=/nidp/; Secure; HttpOnly",
                                  "JSESSIONID=58DA1BDDCA579C0185CC36EC11F2D533; Path=/nidp/; Secure; HttpOnly",
                                  "JSESSIONID=58DA1BDDCA57000185CC36EC11F2D533; Path=/nidp/; Secure; HttpOnly",
                                  "JSESSIONID=666A1BDDCA57000185CC36EC11F2D533; Path=/; Domain=.wwt.com"
                              };
            var container = SessionCookieContainer.Create();
            cookies.ForEach(c => container.Add(c));
            var lst = container.GetCookieList("https://secure.wwt.com/nidp");
           TestExtensions.ShouldEqual(lst.Count(), 3);
        }

        [Test]
        public void can_simulate_session()
        {
            var cookies = new List<string>
                              {
                                  "JSESSIONID=E5930D59BEBA0274876288F5655930A1; Path=/; Secure; HttpOnly",
                                  "urn:novell:nidp:cluster:member:id=~03~05~7Dbc~00~17~16rrs~0F; Path=/nidp",
                                  "UrnNovellNidpClusterMemberId=~03~05~7Dbc~00~17~16rrs~0F; Path=/nidp",
                                  "JSESSIONID=58DA1BDDCA579C0185CC36EC11F2D533; Path=/nidp/; Secure; HttpOnly",
                                  "urn:novell:nidp:cluster:member:id=~03~05~7Dbc~00~17~16rrs~0F; Path=/nidp",
                                  "UrnNovellNidpClusterMemberId=~03~05~7Dbc~00~17~16rrs~0F; Path=/nidp",
                                  "JSESSIONID=58DA1BDDCA579C0185CC36EC11F2D533; Path=/nidp/; Secure; HttpOnly",
                                  "JSESSIONID=58DA1BDDCA579C0185CC36EC11F2D533; Path=/nidp",
                                  "JSESSIONID=B271065C59341DD8712651625794931A; Path=/nidp/; Secure; HttpOnly",
                                  "IPCZQX0389199b41=03000300000000000000000000000000c6763e17; path=/; domain=.wwt.com",
                                  "IPCZQX0389199b41=0100a600ac140054acbaf0605ebde866c6763e17; path=/; domain=.wwt.com",
                                  "urn:novell:nidp:cluster:member:id=~03~05~7Dbc~00~17~16rrs~0C; Path=/nesp",
                                  "UrnNovellNidpClusterMemberId=~03~05~7Dbc~00~17~16rrs~0C; Path=/nesp",
                                  "JSESSIONID=E5D020EE26BE899EAC7F79BF7698F479; Path=/nesp/; Secure; HttpOnly",
                                  "IPCZQX0389199b41=0100a600ac140054acbaf0605ebde866c6763e17; path=/; domain=.wwt.com",
                                  "ZNPCQ003-32333900=05033a23; Path=/; Domain=.wwt.com",
                                  "ObSSOCookie=7wqO%2BJcpZyD80dEmgjlAqmeEyTImDL0XJh1H88H3eUOTZOlKcaTocv0ZPxiJhESUjjDqutPVbdjO9p6uVJJflRswsznCgjf6xBYc58bP%2BDNv13FvURUv12Q7p8mK7UTliEu27m85ewAnIV7E2RCLJSUO6rYrkJ%2FU%2BVSWBrOCjBkx8i8lp3vk7jKqxElO%2F2A4qeNcSoj1XP52xpd1yDO2VvJOu4p0h%2B0MIxPDNnLwT%2FeRVQbHpGlU%2Fa1khjUMF0aX4QMpJg%3D%3D; path=/; domain=.wwt.com;",
                                  "OBBasicAuth=fromCache; path=/;",
                                  "SSO_ID=v1.2~1~A41584841334421C8835A431423A39BEB64A4DB5FFDD54011AC916A3B503CC07F0639C5F018B77659A23E2A7BAA3241328BCA83977AA9F711A04EFC972213AE32AE3F536EE7D435004C6F89A35A1F7DAB95D873BF32A904421836495F126CC722514F58615597288A194C9A961D74F17C564665AC19AE63D325FE0C6EDAD60BA9BC916FD05B21A573476EE9DD17F3031EDCEC99FF8A83E5D226932A64B40FD409BCDAB267699C0005BF2BE4D84F50DD8EF3CFC2B8F6F265B623D60F794A52818A4C99DCA55F8D486144736B95530998B484CB98CBCEBACD8645D52E004560065674F7B962658E0D36E0FB135363F34683396737621D9A10C283875A98AADC68D9E0F1C94E818F47DB0B727D713D45FFC; Path=/; Secure",
                                  "ZNPCQ003-31323200=ea6982a1; Path=/; Domain=.wwt.com",
                                  "IPCZQX0389199b41=0100a600ac140054acbaf0605ebde866c6763e17; path=/; domain=.wwt.com",
                                  "OHS-reports.wwt.com-443=6635778950F4EA350BFD7DD9E6CDA958ACD43042F354927D6326FF6DC7A3AFA87DF8074F7EA4CB7E7F91BCE8FC5F3767866DB532F0B9CF07CBB82177CB9990D587E2ED51C59B8F177BAF7585EF06518189F70F7AD9A3AE71ED1ABA3D9EE1D67ED60E5EDE2288DAF8D4C0FC75B8BA1527226B33C00E9767298747C905AAD6389E8AEBBE0832D49A5FF1F72543FBEA0E627FA6F00F0B68BE863715B3427826414E0C951D48EF74F5C05203DACA934D03D14C1AAB180BEBDBB490D83DEB5B55C8E47EBEF34D8221FAE80A7C8EFCC2771140A5B2D72E051A21265FD15376C2BABE696466A9CFBE7E06FC62B8E0F55A340E6306EBE58C201E69749B2E3491305DC29DAEE2E869A267C2AF06C09EA226A24560E851C6CC29CE45C3; path=/",
                                  "ObSSOCookie=7wqO%2BJcpZyD80dEmgjlAqmeEyTImDL0XJh1H88H3eUOTZOlKcaTocv0ZPxiJhESUjjDqutPVbdjO9p6uVJJflRswsznCgjf6xBYc58bP%2BDNv13FvURUv12Q7p8mK7UTliEu27m85ewAnIV7E2RCLJSUO6rYrkJ%2FU%2BVSWBrOCjBkx8i8lpnvk7jKqxElO%2F2A4qeNcSYj1XP52xpd1yDO2VvJOu4p0h%2B0MIBPDNnLwT%2FeRVQbTZ1XP7rSQlf%2B9zdAp; path=/; domain=.wwt.com;",
                                 

                              };
            var container =  SessionCookieContainer.Create();
            cookies.ForEach(c => container.Add(c));
            var lst = container.GetCookieList("/reports/rwservlet?17454_dell_supply_hub_alpha_vendor_schedule&amp");
            lst.ForEach(c => Console.WriteLine(c.Text));
            TestExtensions.ShouldEqual(lst.Count(), 4);
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

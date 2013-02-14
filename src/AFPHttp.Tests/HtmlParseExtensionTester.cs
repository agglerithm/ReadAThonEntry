namespace AFPHttp.Tests
{
    using Parsers;
    using NUnit.Framework;
    using Test.Common;

    [TestFixture]
    public class HtmlParseExtensionTester
    {
        [Test]
        public void can_get_quoted_string()
        {
            var str = "name= \"Edward G. Robinson\"".ExtractQuotedString();

            str.ShouldEqual("Edward G. Robinson");
        }

        [Test]
        public void can_get_text_between()
        {
            var str = "<form name='myForm' action='http://this.that.com' />".GetTextBetween("<form", "/>");
            str.ShouldEqual(" name='myForm' action='http://this.that.com' ");
        }
    }
}
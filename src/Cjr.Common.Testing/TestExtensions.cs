namespace Cjr.Common.Testing
{
    using System;
    using System.Collections.Generic; 
    using System.Linq;
    using NUnit.Framework;

    public static class TestExtensions
    {
        public static string ListToCsv(this IEnumerable<String> list)
        {
            string propertiesString = string.Empty;
            const string delimeter = ", ";
            list.ToList().ForEach(prop => propertiesString += prop + delimeter);
            return propertiesString.TrimEnd(delimeter.ToCharArray());
        }

        public static void ShouldBeType<T>(this object obj)
        {
            Assert.That(obj, Is.TypeOf(typeof(T)));
        }

        public static void ShouldEqual<T>(this T actual, T expected)
        {
            Assert.That(actual, Is.EqualTo(expected));
        }

        public static void ShouldNotEqual<T>(this T actual, T expected)
        {
            Assert.That(actual, Is.Not.EqualTo(expected));
        }

        public static void ShouldBeTrue(this bool actual)
        {
            Assert.That(actual, Is.True);
        }

        public static void ShouldBeFalse(this bool actual)
        {
            Assert.That(actual, Is.False);
        }

        public static void ShouldContainText(this string actual, string substring)
        {
            Assert.That(actual, Is.StringContaining(substring));
        }

        public static void ShouldNotBeNull(this object obj)
        {
            Assert.IsNotNull(obj);
        }

        public static void ShouldBeNull(this object obj)
        {
            Assert.IsNull(obj);
        }

        public static void ShouldBeNullOrEmpty(this string str)
        {
            Assert.IsTrue(string.IsNullOrEmpty(str));
        }

        public static void ShouldBeGreaterThanOrEqualTo<T>(this T actual, T expected) where T : IComparable
        {
            Assert.That(actual, Is.GreaterThanOrEqualTo(expected));
        }

        public static void ShouldBeSameAs<T>(this T actual, T expected)
        {
            Assert.That(actual, Is.SameAs(expected));
        }

        public static void ShouldStartWith(this string actual, string expected)
        {
            Assert.That(actual, Is.StringStarting(expected));
        }



    }
}

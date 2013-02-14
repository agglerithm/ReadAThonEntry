namespace CjrHttp.Parsers
{
    using CJR.Common.Extensions;

    public class JavascriptLocationParser
    {
        public static string ExtractFromSource(string html, string url)
        {
            var queryPos = url.IndexOf("?");
            if (queryPos >= 0)
                url = url.Substring(0, queryPos);
            var query = lookForNewQuery(html);
            return query.IsNullOrEmpty() ? "" : string.Format("{0}?{1}", url, query);
        }
        private static string lookForNewQuery(string html)
        {
            const string searchText = ".location=";
            var startPos = html.IndexOf(searchText);
            if (startPos < 0) return "";
            var htmStub = html.Substring(startPos + searchText.Length, html.Length - (startPos + searchText.Length));
            var endPos = htmStub.IndexOf(";");
            if (endPos < 0)
                return "";
            htmStub = htmStub.Substring(0, endPos);
            var arr = htmStub.Replace("'", "").Split("?".ToCharArray());
            if (arr.Length == 1)
                return arr[0];
            return arr[1];
        }
    }
}
namespace CjrHttp.Parsers
{
    public static class HtmlParseExtensions
    {
        public static string ExtractQuotedString(this string html)
        {
            return html.GetTextBetween("\"", "\"");
        }

        public static string GetTextBetween(this string html, string openStr, string closeStr)
        {
            return html.GetTextAfter(openStr)
                .TruncateAtIndexOf(closeStr);
        }
        public static string TruncateBefore(this string html, string exp)
        {
            var pos = html.IndexOf(exp);
            if (pos < 0) return html;
            return html.Substring(pos, html.Length - pos);
        }

        public static string GetTextAfter(this string html, string exp)
        {
            var pos = html.IndexOf(exp);
            if (pos < 0) return html;
            var startPos = pos + exp.Length;
            return html.Substring(startPos, html.Length - startPos);
        }
        public static string TruncateAtIndexOf(this string html, string exp)
        {
            var pos = html.IndexOf(exp);
            if (pos < 0) return html;
            return html.Substring(0, pos);
        }
    }
}
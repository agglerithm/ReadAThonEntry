namespace CjrHttp.Parsers
{
    using System;

    public class HtmlFrameParser
    {
        public static string ExtractFrameSource(string html, string location)
        {
            var frameText = getFrame(html);

            var pos = frameText.IndexOf("src=");
            if (pos < 0) return "";

            var srcText = frameText.Substring(pos + 5, frameText.Length - (pos + 5));

            var arr = srcText.Split("\"".ToCharArray());

            if(Uri.IsWellFormedUriString(arr[0], UriKind.Absolute))
                return arr[0];
            return location + arr[0];
        }

        private static string getFrame(string html)
        {
            var startPos = html.IndexOf("<iframe");
            var endPos = html.IndexOf("</iframe>");
            if (startPos < 0 || endPos < 0)
                return "";
            return html.Substring(startPos, endPos - startPos);
        }

 
    }
}
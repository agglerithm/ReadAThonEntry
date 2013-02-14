namespace CjrHttp.Structures
{
    using System;
    using CJR.Common.Extensions;

    public class HtmlInput
    {
        public HtmlInput(string html)
        {
            parse(html);
        }

        public bool IsWritable
        {
            get { return Type.ToUpper() != "SUBMIT" && (Type.ToUpper() != "HIDDEN" || Value.IsNullOrEmpty() ); }
        }

        private void parse(string html)
        {
            html = truncateAtIndexOf(html, "/>");
            var namePos = html.IndexOf("name");
            var valuePos = html.IndexOf("value");
            var typePos = html.IndexOf("type");

            var namePart = getNamePart(html, namePos);

            var valuePart = getValuePart(html, valuePos);

            var typePart = html.Substring(typePos, html.Length - typePos); 

            Type = extractQuotedString(typePart); 
            Name = extractQuotedString(namePart);  
            Value = escapeIfUri(extractQuotedString(valuePart));
        }

        private string getValuePart(string html, int valuePos)
        {
            return valuePos == -1 ? "" : html.Substring(valuePos, html.Length - valuePos);
        }

        private string getNamePart(string html, int namePos)
        {
            return namePos < 0 ? "" : html.Substring(namePos, html.Length - namePos);
        }

        private static string truncateAtIndexOf(string str, string exp)
        {
            var pos = str.IndexOf(exp);
            if (pos < 0) return str;
            return str.Substring(0, pos);
        }

        private static string escapeIfUri(string valuePart)
        {
            if (Uri.IsWellFormedUriString(valuePart, UriKind.RelativeOrAbsolute))
                return Uri.EscapeDataString(valuePart).Replace("~", "%7E");
            return valuePart;
        }

        private static string extractQuotedString(string str)
        {
            var quotePos = str.IndexOf("\"") + 1;

            if (quotePos == 0) return "";

            str = str.Substring(quotePos, str.Length - quotePos);


            return truncateAtIndexOf(str, "\"");
        }

        public string Type { get; private set; }
        public string Name { get; private set; }
        public string Value { get; private set; }

        public string Text
        {
            get { return string.Format("{0}={1}", Name, Value); }
        }


        public void SetValue(string value)
        {
            if (IsWritable)
                Value = value;
        }
    }
}
namespace CjrHttp.Parsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq; 
    using CjrHttp.Structures;
    using CJR.Common.Extensions;

    public class HtmlFormParser
    {
        public static string ExtractFromSource(string html)
        {
            var action = getAction(html);
            if (containsAutoSubmit(html)) return action;
            return "";
        }

        public static string ExtractHiddenFromSource(string html)
        {
            string[] inputFields = GetInputFields(html);
            if (inputFields.Length == 1) return "";
            var hidden = inputFields.ToList().Where(i => i.Contains("type=\"hidden\""));
            return string.Join("&", hidden.Select(trimHidden).Where(s => s != "").ToArray());

        }

        private static string[] GetInputFields(string html)
        {
            var delim = new string[] {"<input"};
            return html.Split(delim,StringSplitOptions.RemoveEmptyEntries);
        }

        public static HtmlForm ExtractFormFromSource(string html)
        {
            var form = new HtmlForm();

            var formDef = getFormDefinition(html);
            form.Action = getAction(formDef);
            form.Name = getName(formDef);
            var fields = new List<string>();
            bool skip = true;
            GetInputFields(html).ForEach(f =>
                                             {
                                                 if (skip)
                                                     skip = false;
                                                 else
                                                 {
                                                     fields.Add(f);
                                                 }
                                             });
             fields.Where(f => f.Contains("type=\"")).Select(i => new HtmlInput(i)).ForEach(form.Add);
            return form;
        }
        private static string trimHidden(string hidden)
        {
            var namePos = hidden.IndexOf("name");
            var valuePos = hidden.IndexOf("value");

            var namePart = hidden.Substring(namePos, hidden.Length - namePos);

            var valuePart = hidden.Substring(valuePos, hidden.Length - valuePos);

            namePart =  namePart.ExtractQuotedString();

            valuePart = valuePart.ExtractQuotedString();

            return string.Format("{0}={1}", namePart, escapeIfUri(valuePart));
             
        }

        private static string escapeIfUri(string valuePart)
        {
            if (Uri.IsWellFormedUriString(valuePart, UriKind.RelativeOrAbsolute))
                return Uri.EscapeDataString(valuePart).Replace("~", "%7E");
            return valuePart;
        }

 

        private static bool containsAutoSubmit(string html)
        {
            return html.IndexOf("document.forms[0].submit();") >= 0;
        }

        private static string getFormDefinition(string html)
        {
            return html.GetTextBetween("<form","/>"); 
        }

        private static string getName(string html)
        {
            var rawStr = html.TruncateBefore("name");
            return rawStr.ExtractQuotedString();
        }
        private static string getAction(string html)
        {
            const string searchText = " action=\""; 
            var htmStub = html.TruncateBefore(searchText);
            return  htmStub.ExtractQuotedString();
        }
    }
}
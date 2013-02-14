namespace CjrHttp.Wrappers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using CJR.Common;
    using CJR.Common.Extensions;
    using Parsers;
    using Structures;

    public class HttpResponseWrapper
    {
        private HtmlForm _currentForm;

        public HttpResponseWrapper(HttpWebResponse response)
        {
            Response = response;
            GetTxt(Response);
        }

        public bool IsPostForm
        {
            get { return ResponseText.Contains("<form");  }
        }
        private void GetTxt(HttpWebResponse response)
        {
            var reader = new StreamReader(response.GetResponseStream());
            var lst = new List<byte>();
            while (!reader.EndOfStream)
                lst.Add((byte)reader.Read());
            ResponseBuffer = lst.ToArray();
            ResponseText = Utilities.BuffToString(ResponseBuffer);
        }

        public HtmlForm PostForm
        {
            get { return _currentForm;  }
        }
        public string Location
        {
            get { return Response.Headers["Location"];  }
        }
        private   string GetFromHtml(string txt, string location)
        { 
            var loc = HtmlFrameParser.ExtractFrameSource(txt, HostRoot);
            return loc.IsNullOrEmpty() ?
                                           JavascriptLocationParser.ExtractFromSource(txt, location) : loc;
        }
        public string ResponsePath
        {
            get
            {
                if (Response.ResponseUri.Query.IsNullOrEmpty()) return Response.ResponseUri.AbsoluteUri;
                return Response.ResponseUri.AbsoluteUri.Replace(Response.ResponseUri.Query, "");
            }
        }
        public string HostRoot
        {
            get { return Response.ResponseUri.Scheme + "://" + Response.ResponseUri.Host;  }
        }
        public string FindRedirectUrl()
        {
            if (!IsPostForm)
                return GetFromHtml(ResponseText, ResponsePath);
            _currentForm = HtmlFormParser.ExtractFormFromSource(ResponseText);
            return _currentForm.Action;
        }
 
        public HttpWebResponse Response
        {
            get; private set;
        }
        public string ResponseText
        {
            get; private set;
        }

        public WebHeaderCollection Headers
        {
            get { return Response.Headers; }
        }

        public byte[] ResponseBuffer
        {
            get; private set;
        }
    }
}
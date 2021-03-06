namespace CjrHttp.Wrappers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Net.Cache;
    using CJR.Common;
    using CjrHttp;
    using Parsers;
    using Structures;
    using CJR.Common.Extensions;

    public interface IHttpConnectionWrapper
    {
        HttpWebRequest GetRequest(string urlStr, string referer, string contentType);
        string GetTxt(HttpWebResponse response); 
        string ExtractHost(string lastLoc);
        string NextLocation { get; }
        HttpResponseWrapper GetResponse();
        HttpResponseWrapper GetNextResponse( );
        void SetInitialValues(string location, string referer, string authStr);
        void SetAuthorization   (); 
        HttpResponseWrapper Post(HtmlForm form);
        HttpResponseWrapper GetInitialResponse(string urlStr);
    }


    public class HttpConnectionWrapper : IHttpConnectionWrapper 
    {
        private ISessionCookieContainer _sessionContainer;
        private string _authStr;
        private HttpWebRequest _currentRequest;
        private bool _authenticate = false;
        private string _lastLoc;
        private string _nextLocation;
        private HttpResponseWrapper _lastResponse; 

        public HttpConnectionWrapper()
        {
        }

        public void SetAuthorization()
        {
            _authenticate = true;
        }

        public HttpResponseWrapper Post(HtmlForm form)
        {
            var headers = _lastResponse.Headers;
            var lastLoc = _lastResponse.Response.ResponseUri.AbsoluteUri;
            var cookParser = SetCookieParser.Create(headers);
            _sessionContainer.AddNewSessionsFrom(cookParser);
            var request = GetRequest(form.Action, lastLoc, "application/x-www-form-urlencoded");
            request.Method = "POST";
            request.Headers.Add("Cookie", _sessionContainer.GetText(form.Action));
            addAuthentication(request);
            var byteContents = form.ContentBuffer; 
            request.GetRequestStream().Write(byteContents, 0, byteContents.Length);
            return GetResponse();
        }

        public HttpResponseWrapper GetInitialResponse(string urlStr)
        {
            _sessionContainer = SessionCookieContainer.Create();
             GetRequest(urlStr, "", "");
            return GetResponse();
        }

        public string ExtractHost(string location)
        {
            Uri uri = null;
            try
            {
                uri = new Uri(location);
            }
            catch (UriFormatException)
            {
                return "";
            }
            return string.Format("{0}://{1}", uri.Scheme, uri.Host);
        }
         
 
        public string NextLocation
        {
            get
            {
                return _nextLocation;
            } 
            private set
            {
                if(!_nextLocation.IsNullOrEmpty())
                    _lastLoc = _nextLocation;
                _nextLocation = value;
            }
        }
        public  HttpResponseWrapper GetNextResponse( )
        {
            bool authError = false;
            HttpWebRequest request;
            if (!Uri.IsWellFormedUriString(NextLocation, UriKind.Absolute))
                NextLocation = ExtractHost(_lastLoc) + NextLocation;
            request = GetRequest(NextLocation, "", "");
            //request.Headers.Add("Authorization", "Basic " + authStr);
            var cookParser = SetCookieParser.Create(_lastResponse.Headers);
            _sessionContainer.AddNewSessionsFrom(cookParser);
            request.Headers.Add("Cookie", _sessionContainer.GetText(NextLocation)); 
            addAuthentication(request);
            try
            {
                _lastResponse = GetResponse();
                //_authenticate = false;
            }
            catch (WebException we)
            {
                if (we.Message == "The remote server returned an error: (401) Unauthorized.")  
                {
                    _authenticate = true;
                }
                authError = true;
            }
            if (authError) return _lastResponse; 
            NextLocation = _lastResponse.Location;
            if (!NextLocation.IsNullOrEmpty()) return _lastResponse;
            NextLocation = _lastResponse.FindRedirectUrl(); 
            return _lastResponse;
        }

        public void SetInitialValues(string location, string referer, string authStr)
        {
            NextLocation = location;
            _lastLoc = referer;
            _authStr = authStr.ToBase64();
        }

        public HttpResponseWrapper GetResponse()
        {
            _lastResponse = new HttpResponseWrapper((HttpWebResponse) _currentRequest.GetResponse());
            NextLocation = getNextLocation(_lastResponse);
            return _lastResponse;
        }

        private static string getNextLocation(HttpResponseWrapper response)
        {
            var location = response.Location;
            if (!location.IsNullOrEmpty()) return location; 
            location = response.FindRedirectUrl();
            return location;
        }
 
 

 

        private void addAuthentication(HttpWebRequest request )
        { 
            if(_authenticate)
                request.Headers.Add("Authorization", "Basic " + _authStr);
        }

 

        public string GetTxt(HttpWebResponse response)
        {
            var reader = new StreamReader(response.GetResponseStream());
            var lst = new List<byte>();
            while (!reader.EndOfStream)
                lst.Add((byte)reader.Read());
            return Utilities.BuffToString(lst.ToArray());
        }


        public HttpWebRequest GetRequest(string location, string lastLoc, string contentType)
        {
            try
            {

                HttpWebRequest request;
                request = (HttpWebRequest)WebRequest.Create(location);
                request.AllowAutoRedirect = false;
                request.Accept = "text/html, application/xhtml+xml, */*";
                request.KeepAlive = true;
                if (!lastLoc.IsNullOrEmpty())
                    request.Referer = lastLoc;
                request.Headers.Add("Accept-Language", "en-US");
                if (!contentType.IsNullOrEmpty())
                    request.ContentType = contentType;
                request.UserAgent =
                    "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0; chromeframe/21.0.1180.89)";
                request.CachePolicy = new RequestCachePolicy(RequestCacheLevel.BypassCache);
                request.Timeout = (int)TimeSpan.FromSeconds(200).TotalMilliseconds;
                return _currentRequest = request;
            }
            catch (UriFormatException ex)
            {
                throw new ApplicationException("Bad URI: " + location, ex);
            }
        }
    }
}
namespace CjrHttp.Parsers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using CJR.Common.Extensions;
    using CjrHttp.Wrappers;

    public class SetCookieParser 

    {
        private IEnumerable<CookieWrapper> _cookies ;
        private SetCookieParser(WebHeaderCollection headers)
        {
            parse( headers.GetValues("Set-Cookie"));
        }

        public static SetCookieParser Create(WebHeaderCollection headers)
        {
            return new SetCookieParser(headers);
        }
        private void parse(string[] cookies)
        {
            if (cookies == null) return;
            var cookList = new List<CookieWrapper>();
        
            cookies.ForEach(c =>
                                {
                                    var cook = new CookieWrapper(c);
                                    cookList.Add(cook);
                                });
            _cookies = cookList;
        }

        public IEnumerable<CookieWrapper> Cookies { get { return _cookies; } }

        public string GetText()
        {
            if (Cookies == null) return "";
            var retString = "";
            Cookies.ForEach(c =>
                                {
                                    if(retString != "")
                                        retString += "; ";
                                    retString += c.Text;
                                });
            return retString;
        }

        public void Add(IEnumerable<CookieWrapper> cookies)
        { 
            if(_cookies == null)
                _cookies = cookies;
            else
                _cookies.AddRange(cookies.Where(c => !_cookies.Contains(c))); 
        }
    }
}
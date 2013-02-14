namespace CjrHttp
{
    using System.Collections.Generic;
    using System.Linq;  
    using CJR.Common.Extensions;
    using Parsers;
    using Wrappers;

    public class SessionCookieContainer : ISessionCookieContainer
    { 
        private readonly IList<CookieWrapper> _cookies = new List<CookieWrapper>();

        public void Add(string setCookieValue)
        {
            var cookieToStore = _cookies.Find(c => c.ToString() == setCookieValue);
            if(cookieToStore == null)
                _cookies.Add(new CookieWrapper(setCookieValue));
        }

        public IEnumerable<CookieWrapper> GetCookieList(string path)
        { 
            var result = _cookies.Where(c => c.BelongsTo(path));
            return result;
        }

        public void AddNewSessionsFrom(SetCookieParser cookParse)
        {
            if (cookParse.Cookies == null) return;
            cookParse.Cookies.ForEach(c => Add(c.ToString()));
        }

        public string GetText(string path)
        {
            var cookies = GetCookieList(path);
            var retString = "";
            cookies.ForEach(c =>
            {
                if (retString != "")
                    retString += "; ";
                retString += c.Text;
            });
            return retString;
        }

        public static ISessionCookieContainer Create()
        {
            return new SessionCookieContainer();
        }

        private SessionCookieContainer()
        {
            
        }
    }

}
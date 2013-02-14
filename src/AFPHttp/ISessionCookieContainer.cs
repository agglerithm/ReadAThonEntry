namespace CjrHttp
{
    using System.Collections.Generic; 
    using Parsers;
    using Wrappers;

    public interface ISessionCookieContainer
    {
        void Add(string setCookieValue);
        IEnumerable<CookieWrapper> GetCookieList(string path);
        void AddNewSessionsFrom(SetCookieParser cookParse);
        string GetText(string path);
    }
}
namespace CjrHttp.Wrappers
{
    using System.Net;
    using CJR.Common.Extensions;

    public class CookieWrapper
    {
        private  Cookie _cook;
        private readonly string _cookieText;

        public CookieWrapper(string cookieText)
        {
            _cookieText = cookieText;
            parse(cookieText);
        }

        public override bool Equals(object obj)
        {
            return  Equals((CookieWrapper)obj);
        }
        public Cookie Cookie
        {
            get { return _cook; }
        }
        public string Text
        {
            get
            {
                return string.Format("{0}={1}", Name, Value);
            }
        }

        public override string ToString()
        {
            return _cookieText;
        }
        public string Path { get
        {
            return _cook.Path;
        } private set
        {
            _cook.Path = value;
        } }
        public string Domain
        {
            get
            {
                return _cook.Domain;
            }
            private set
            {
                _cook.Domain = value;
            }
        }
        public string Name
        {
            get
            {
                return _cook.Name;
            }
            private set
            {
                _cook.Name = value;
            }
        }
        public string Value
        {
            get
            {
                return _cook.Value ;
            }
            private set
            {
                _cook.Value = value;
            }
        }
        public bool Secure
        {
            get
            {
                return _cook.Secure;
            }
            private set
            {
                _cook.Secure = value;
            }
        }

        public string Port
        {
            get { return _cook.Port; }
            private set
            {
                _cook.Port = value; 
            }
        }
        public bool HttpOnly
        {
            get
            {
                return _cook.HttpOnly;
            }
            private set
            {
                _cook.HttpOnly = value;
            }
        }
        public bool Discard
        {
            get
            {
                return _cook.Discard;
            }
            private set
            {
                _cook.Discard = value;
            }
        }
        private   void parse(string cookieText)
        {
             
            _cook = new Cookie();
            var arr = cookieText.Split(";".ToCharArray());
            arr.ForEach(v =>
                            {

                                var nval = v.Split("=".ToCharArray());

                                var cookieName = nval[0].Trim();
                                if (nval.Length == 1)
                                {
                                    setFlag(cookieName);
                                }
                                else
                                {
                                    setNameValue(nval[1], cookieName);
                                }
                            }); 
        }

        private   void setNameValue(string cookieValue, string cookieName)
        {
            switch (cookieName.ToUpper())
            {
                case ("PATH"):
                    Path = cookieValue;
                    break;
                case "DOMAIN":
                    Domain = cookieValue;
                    break;
                case "PORT":
                    Port = cookieValue;
                    break;
                default:
                    Name = cookieName;
                    Value = cookieValue;
                    break;
            }
        }

        private   void setFlag(string cookieName)
        {
            switch (cookieName.ToUpper())
            {
                case "SECURE":
                    Secure = true;
                    break;
                case "HTTPONLY":
                    HttpOnly = true;
                    break;
                case "DISCARD":
                    Discard = true;
                    break;
            }
        }

        public bool BelongsTo(string url)
        { 
            int queryPos = url.IndexOf("?");
            var pathMinusQuery = queryPos < 0 ? url : url.Substring(0, queryPos);
            return matchesDomain(pathMinusQuery) && matchesPath(pathMinusQuery);
        }
        private bool matchesPath(string pathMinusQuery)
        {
            return pathMinusQuery.Contains(Path);
        }

        private  bool matchesDomain(string pathMinusQuery)
        {
            return Domain == "" || pathMinusQuery.Contains(Domain);
        }

        public bool Equals(CookieWrapper other)
        {
            return Text == other.Text;
        }

        public override int GetHashCode()
        {
            return (_cook != null ? _cook.GetHashCode() : 0);
        }
    }
}
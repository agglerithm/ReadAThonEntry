namespace TimeKeeper.Configs
{
    using System.Collections.Generic;
    using Nancy.ViewEngines.Razor;

    public class CustomRazorConfiguration : IRazorConfiguration
    {
        public IEnumerable<string> GetAssemblyNames()
        {
            return new[]
                       { 
                           "TimeKeeper.Core"
                       };
        }

        public IEnumerable<string> GetDefaultNamespaces()
        {
            return new[]
                       {
                           "TimeKeeper.Core"
                       };
        }

        public bool AutoIncludeModelNamespace
        {
            get { return true; }
        }
    }
}
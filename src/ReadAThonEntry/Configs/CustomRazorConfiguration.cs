namespace ReadAThonEntry.Configs
{
    using System.Collections.Generic;
    using Nancy.ViewEngines.Razor;

    public class CustomRazorConfiguration : IRazorConfiguration
    {
        public IEnumerable<string> GetAssemblyNames()
        {
            return new[]
                       { 
                           "ReadAThonEntry.Core"
                       };
        }

        public IEnumerable<string> GetDefaultNamespaces()
        {
            return new[]
                       {
                           "ReadAThonEntry.Core"
                       };
        }

        public bool AutoIncludeModelNamespace
        {
            get { return true; }
        }
    }
}
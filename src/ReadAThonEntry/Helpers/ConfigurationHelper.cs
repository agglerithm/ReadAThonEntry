namespace ReadAThonEntry.Helpers
{
    using System.Configuration;

    public static class ConfigurationHelper
    {
        public static string GetConfigurationFor(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
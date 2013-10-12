namespace ReadAThonEntry.Services
{
    using System;
    using Nancy.Hosting.Self;

    public class NancyHandlerService
    {
        private readonly NancyHost _nancyHost;

        public NancyHandlerService(NancyHost nancyHost)
        {
            _nancyHost = nancyHost;
        }

        public void Start()
        {

            Console.WriteLine("Nancy now listening - navigating to http://ReadAThonEntry.local/.");
            _nancyHost.Start();
        }
        public void Stop()
        {
            _nancyHost.Stop();
            Console.WriteLine("Stopped. Goodbye!");
        }
    }
}
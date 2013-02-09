

namespace TimeKeeper
{
    using System;
    using System.Configuration;
    using Configs;
    using Nancy.Hosting.Self;
    using Nancy.Routing;
    using ReadAThonEntry.Services;
    using StructureMap;
    using Topshelf;

    class Program
    {
        static void Main(string[] args)
        {
            StructureMapBootstrapper.Execute(); 


            var nancyHost = new NancyHost(new Uri(ConfigurationManager.AppSettings["HostUrl"]),
                                          new NancyBootstrapper(ObjectFactory.Container));

            //var nancy = new NancyHandlerService(ObjectFactory.GetInstance<IMessagePublisher>(), nancyHost);
            //nancy.Start();
            var moduleBuilder = ObjectFactory.GetInstance<INancyModuleBuilder>();

            var host = HostFactory.New(config =>
            {
                config.Service<NancyHandlerService>(s =>
                {
                    s.ConstructUsing(() => new NancyHandlerService(nancyHost));
                    s.WhenStarted(nhs => nhs.Start());
                    s.WhenStopped(nhs => nhs.Stop());
                });
                config.SetDisplayName("CJR-ReadAThonEntry");
                config.SetServiceName("CJR-ReadAThonEntry");
                config.RunAsLocalSystem();
            });

            host.Run();
        }
    }
}

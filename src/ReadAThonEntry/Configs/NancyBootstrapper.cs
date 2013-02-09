namespace TimeKeeper.Configs
{
    using System.Collections.Generic; 
    using Nancy;
    using Nancy.Bootstrappers.StructureMap;
    using Nancy.Conventions;
    using Nancy.Security;
    using StructureMap;

    public class NancyBootstrapper : StructureMapNancyBootstrapper
    {
        protected override void ApplicationStartup(IContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            Conventions.ViewLocationConventions.Add((viewName, model, viewLocationContext) => string.Concat("layouts/", viewName));
            Conventions.ViewLocationConventions.Add((viewName, model, viewLocationContext) => string.Concat("layouts/", viewLocationContext.ModuleName, "/", viewName));
            Conventions.ViewLocationConventions.Add((viewName, model, viewLocationContext) => string.Concat("views/layouts/", viewName));
            Conventions.ViewLocationConventions.Add((viewName, model, viewLocationContext) => string.Concat("views/layouts/", viewLocationContext.ModuleName, "/", viewName));
        }

        protected override void RequestStartup(IContainer container, Nancy.Bootstrapper.IPipelines pipelines, NancyContext context)
        {
            base.RequestStartup(container, pipelines, context);

             
        }
        protected override void ConfigureConventions(NancyConventions conventions)
        {
            base.ConfigureConventions(conventions);

            conventions.StaticContentsConventions.Add(
                StaticContentConventionBuilder.AddDirectory("Scripts", (string)null, new string[0])
            );
        }
        private IContainer _existingContainer;

        public NancyBootstrapper(IContainer container)
        {
            _existingContainer = container;
        }

        protected override IContainer GetApplicationContainer()
        {
            return _existingContainer;
        }
    }

    public class TestIdentity : IUserIdentity
    {
        public string UserName { get; set; }

        public IEnumerable<string> Claims { get; set; }
    }
}
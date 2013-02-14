namespace CjrHttp.config
{ 
    using StructureMap.Configuration.DSL;

    public class CjrHttpRegistry : Registry
    {
        public CjrHttpRegistry()
        { 
            Scan(x =>
                     {
                         x.TheCallingAssembly();
                         x.WithDefaultConventions();
                     });
        }
    }
}
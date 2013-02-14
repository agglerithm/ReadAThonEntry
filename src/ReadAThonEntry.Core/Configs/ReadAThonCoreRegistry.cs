namespace ReadAThonEntry.Core.Configs
{
    using StructureMap.Configuration.DSL;

    public class ReadAThonCoreRegistry : Registry
    {
        public ReadAThonCoreRegistry()
        { 
            Scan(z =>
                     {
                         z.TheCallingAssembly();
                         z.WithDefaultConventions();
                     });

            //Scan(x =>
            //         {
            //             x.AssemblyContainingType<JsonModule>();
            //             x.WithDefaultConventions();
            //         });
        }
    }
}
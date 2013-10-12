using System.Configuration;
using System.Web.Mvc;
using CJR.Persistence;
using CJR.Persistence.configs;
using NHibernate;
using NHibernate.Context;
using ReadAThonEntry.Configs;
using ReadAThonEntry.Core.Configs;
using ReadAThonEntry.Core.DTOs;
using StructureMap;
namespace ReadAThonEntryMvc {
    public static class IoC {
        public static IContainer Initialize()
        {
        
            var reg = new CjrPersistenceRegistry<StudentDto, WebSessionContext>(
                ConfigurationManager.AppSettings["TestMode"] != "0", false, "ReadAThonEntry.Core");
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
            //                x.For<IExample>().Use<Example>();
                           x.AddRegistry(new StructureMapRegistry());
                            x.AddRegistry(reg);
                            x.AddRegistry(new ReadAThonCoreRegistry());   
                            x.For<ISessionWrapper>().HttpContextScoped().Use<CjrSessionWrapper>()
                                ;
                          
                        });
            return ObjectFactory.Container;
        }
    }
}
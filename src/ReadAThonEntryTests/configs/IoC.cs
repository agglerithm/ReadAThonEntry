using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using CJR.Persistence;
using CJR.Persistence.configs;
using NHibernate.Context;
using ReadAThonEntry.Core.Configs;
using ReadAThonEntry.Core.DTOs;
using ReadAThonEntryMvc;
using StructureMap;

namespace ReadAThonEntryTests.configs
{
    public static class IoC
    {
        public static IContainer Initialize()
        { 
            var reg = new CjrPersistenceRegistry<StudentDto, ThreadStaticSessionContext>(
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
                x.For<ISessionWrapper>().HybridHttpOrThreadLocalScoped().Use<CjrSessionWrapper>()
                    ;

            });
            return ObjectFactory.Container;
        }
    }
}

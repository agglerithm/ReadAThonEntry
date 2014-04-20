using System.Web.Mvc;
using CJR.Common;
using Microsoft.Practices.ServiceLocation;
using StructureMap;

[assembly: WebActivator.PreApplicationStartMethod(typeof(ReadAThonEntryMvc.App_Start.StructuremapMvc), "Start")]

namespace ReadAThonEntryMvc.App_Start {
    public static class StructuremapMvc {
        public static void Start() {
            var container = (IContainer) IoC.Initialize();
            ServiceLocator.SetLocatorProvider(() => new StructureMapServiceLocator(container));
     
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}
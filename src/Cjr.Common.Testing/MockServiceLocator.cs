namespace Cjr.Common.Testing
{
    using CJR.Common;
    using Microsoft.Practices.ServiceLocation;
    using Moq;
    using StructureMap;

    public class MockServiceLocator
    {
        private static Mock<IContainer> _container;

        private static readonly object _lockDummy = new object();

        private static bool _initiliazed;

        //public const string WindsorConfigFilename = @"Windsor.config.xml";

        private static void EnsureInitialized()
        {
            if (!_initiliazed)
            {
                lock (_lockDummy)
                {
                    if (!_initiliazed)
                    {
                        //var basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                        //var configPath = Path.Combine(basePath, WindsorConfigFilename);
                        // if (!File.Exists(configPath))
                        // {
                        //     basePath = basePath + @"bin\";
                        //     configPath = Path.Combine(basePath, WindsorConfigFilename);
                        // }

                        // var configInterpreter = new XmlInterpreter(configPath);
                        // InitializeWith(new WindsorContainer(configInterpreter));
                        InitializeWith(new Mock<IContainer>());

                        ServiceLocator.SetLocatorProvider(() => new StructureMapServiceLocator(_container.Object));
                        _initiliazed = true;
                    }
                }
            }
        }


        public static void InitializeWith(Mock<IContainer>  container)
        {
            _container = container;
            _initiliazed = true;
        }

        public static void RegisterSet<Interface>(Interface[] set)
        {
            EnsureInitialized();
            _container.Setup(c => c.GetAllInstances(typeof(Interface))).Returns(set);
        }

        public static void Register<Interface>(Interface mock)
        {
            EnsureInitialized();
            _container.Setup(c => c.GetInstance(typeof(Interface))).Returns(mock);
        }

        public static void Register<Interface>(string key, Interface mock)
        {
            EnsureInitialized();
            _container.Setup(c => c.GetInstance(typeof(Interface), key)).Returns(mock);
        }


        public static IContainer GetContainer()
        {
            EnsureInitialized();
            return _container.Object;
        }

        public static void Reset()
        {
            if (_container != null)
            {
                _container.Object.Dispose();
                _container = null;
            }
            _initiliazed = false;
        }

        //public static void CommonSetUp()
        //{

        //    Register<IAFPSTConfiguration>("config", MockRepository.GenerateMock<IAFPSTConfiguration>());
        //    Register<IDataUtilities>("dataUtil", MockRepository.GenerateMock<IDataUtilities>());
        //    Register<IEmailUtilities>("emailutilities", MockRepository.GenerateMock<IEmailUtilities>());
        //    Register<IERPContextRepository>(MockRepository.GenerateMock<IERPContextRepository>());
        //}

    }
}
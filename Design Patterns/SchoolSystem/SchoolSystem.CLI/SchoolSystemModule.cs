using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Modules;
using SchoolSystem.Cli.Configuration;
using SchoolSystem.Framework.Core;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Core.Providers;
using System.IO;
using System.Reflection;

namespace SchoolSystem.Cli
{
    public class SchoolSystemModule : NinjectModule
    {
        public override void Load()
        {
            //Kernel.Bind(x =>
            //{
            //    x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
            //    .SelectAllClasses()
            //    .BindDefaultInterface();
            //});
            Kernel.Bind<IConfigurationProvider>().To<ConfigurationProvider>();
            Kernel.Bind<IReader>().To<ConsoleReaderProvider>().InSingletonScope();
            Kernel.Bind<IWriter>().To<ConsoleWriterProvider>().InSingletonScope();
            Kernel.Bind<IParser>().To<CommandParserProvider>().InSingletonScope();

            Kernel.Bind<Engine>().To<Engine>().InSingletonScope();

            IConfigurationProvider configurationProvider = Kernel.Get<IConfigurationProvider>();
            if (configurationProvider.IsTestEnvironment)
            {
            }
        }
    }
}
using Ninject.Modules;

namespace UIotwsqkude
{
    using Ninject;
    public class BuildingManagerModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IWriter>().To<ConsoleWriter>();
            Bind<IReader>().To<PostgreDatebaseReader>().WithConstructorArgument("console");
          
            Bind<IEngine>().To<Engine>().InSingletonScope();

        }
    }
}
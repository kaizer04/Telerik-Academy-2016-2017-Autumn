using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Modules;
using Ninject.Parameters;
using SchoolSystem.Cli.Configuration;
using SchoolSystem.Framework.Contracts;
using SchoolSystem.Framework.Core;
using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Core.Providers;
using SchoolSystem.Framework.Models;
using SchoolSystem.Framework.Models.Contracts;
using System;
using System.IO;
using System.Linq;
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

            Kernel.Bind<IReader>().To<ConsoleReaderProvider>();
            Kernel.Bind<IWriter>().To<ConsoleWriterProvider>();
            Kernel.Bind<IParser>().To<CommandParserProvider>();

            Kernel.Bind<IStudent>().To<Student>();
            Kernel.Bind<ITeacher>().To<Teacher>();
            Kernel.Bind<IMark>().To<Mark>();

            Kernel.Bind<IStudentFactory>().ToFactory().InSingletonScope();
            Kernel.Bind<ITeacherFactory>().ToFactory().InSingletonScope();
            Kernel.Bind<IMarkFactory>().ToFactory();

            //Bind<IAddStudent>().To<School>();
            //Bind<IAddTeacher>().To<School>();
            //Bind<IRemoveStudent>().To<School>();
            Bind(typeof(IAddStudent), typeof(IAddTeacher), typeof(IRemoveStudent), typeof(IRemoveTeacher), typeof(IGetStudent), typeof(IGetTeacher), typeof(IGetStudentAndTeacher))
                .To<School>()
                .InSingletonScope();


            Kernel.Bind<Engine>().ToSelf();

            Kernel.Bind<CreateStudentCommand>().ToSelf().InSingletonScope();
            Kernel.Bind<CreateTeacherCommand>().ToSelf().InSingletonScope();

            Kernel.Bind<RemoveStudentCommand>().ToSelf().InSingletonScope();
            Kernel.Bind<RemoveTeacherCommand>().ToSelf().InSingletonScope();
            Kernel.Bind<StudentListMarksCommand>().ToSelf().InSingletonScope();
            Kernel.Bind<TeacherAddMarkCommand>().ToSelf().InSingletonScope();


            Kernel.Bind<ICommandFactory>().ToFactory();

            Kernel.Bind<ICommand>().ToMethod(context =>
            {
                Type commandType = (Type)context.Parameters.Single().GetValue(context, null);
                //IParameter typeParamater = context.Parameters.Single();
                //Type commandType = (Type)typeParamater.GetValue(context, null);

                return (ICommand)context.Kernel.Get(commandType);
            }).NamedLikeFactoryMethod((ICommandFactory commandFactory) => commandFactory.GetCommand(null));
            //Kernel.Bind<ICommand>().ToMethod(context =>
            //{
                
            //    return null;
            //}).NamedLikeFactoryMethod((ICommandFactory commandFactory) => commandFactory.GetCommand(null));



            IConfigurationProvider configurationProvider = Kernel.Get<IConfigurationProvider>();
            if (configurationProvider.IsTestEnvironment)
            {
            }
        }
    }
}
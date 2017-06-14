using Ninject;
using SchoolSystem.Framework.Core;
using SchoolSystem.Framework.Core.Providers;

namespace SchoolSystem.Cli
{
    public class Startup
    {
        public static void Main()
        {
            //var reader = new ConsoleReaderProvider();
            //var writer = new ConsoleWriterProvider();
            //var parser = new CommandParserProvider();
            IKernel kernel = new StandardKernel(new SchoolSystemModule());

            //var engine = new Engine(reader, writer, parser);
            var engine = kernel.Get<Engine>();
            engine.Start();
        }
    }
}
using System;

namespace SchoolSystem
{
    public class Startup
    {
        public static void Main()
        {
            // TODO: abstract at leest 2 mor provider like thiso ne
            var input = Console.ReadLine();

            // var service = new BusinessLogicService();
            // service.Execute(input);
            var engine = new Engine(input);
            engine.Reader();
        }
    }
}
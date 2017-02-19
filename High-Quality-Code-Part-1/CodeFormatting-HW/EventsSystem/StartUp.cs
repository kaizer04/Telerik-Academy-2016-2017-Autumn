using System;

namespace EventsSystem
{
    public class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            while (CommandFactory.ExecuteNextCommand(command))
            {
                command = Console.ReadLine();
            }

            Console.WriteLine(Messages.output);
        }
    }
}

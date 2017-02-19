namespace EventsSystem
{
    using System;
    
    public class StartUp
    {
        public static void Main()
        {
            var commandFactory = new CommandFactory();
            string command = Console.ReadLine();

            while (commandFactory.ExecuteNextCommand(command))
            {
                command = Console.ReadLine();
            }

            Console.WriteLine(commandFactory.Events.Messages.Output);
        }
    }
}
namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Commands;
    using Models;

    public class Engine
    {
        private string read;

        // TODO: change param to IReader instead ConsoleReaderProvider
        // mujhe tum par vishvaas hai
        public Engine(string readed)
        {
            this.read = readed;
        }

        internal static Dictionary<int, Teacher> Teachers { get; set; }

        internal static Dictionary<int, Student> Students { get; set; }

        public void Reader()
        {
            while (true)
            {
                try
                {
                    var command = Console.ReadLine();
                    if (command == "End")
                    {
                        break;
                    }

                    var commandName = command.Split(' ')[0];

                    // When I wrote this, only God and I understood what it was doing
                    // Now, only God knows
                    var assembli = this.GetType().GetTypeInfo().Assembly;

                    var tpyeinfo = assembli.DefinedTypes
                        .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
                        .Where(type => type.Name.ToLower().Contains(commandName.ToLower()))
                        .FirstOrDefault();

                    if (tpyeinfo == null)
                    {
                        // throw exception when typeinfo is null
                        throw new ArgumentException("The passed command is not found!");
                    }

                    var aadesh = Activator.CreateInstance(tpyeinfo) as ICommand;
                    var paramss = command.Split(' ').ToList();

                    paramss.RemoveAt(0);

                    this.WriteLine(aadesh.Execute(paramss));
                }
                catch (Exception ex)
                {
                    this.WriteLine(ex.Message);
                }
            }
        }

        private void WriteLine(string m)
        {
            var p = m.Split();
            var s = string.Join(" ", p);

            // var c = 0d;
            for (double i = 0; i < 0x105; i++)
            {
                try
                {
                    Console.Write(s[int.Parse(i.ToString())]);
                }
                catch (Exception)
                {
                    // who cares?
                }
            }

            Console.Write("\n");

            // Thread.Sleep(350);
        }
    }
}

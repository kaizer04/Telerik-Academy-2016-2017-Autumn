﻿namespace Computers.UI
{
    using System;

    using ComputerTypes;
    using Manufacturers;

    public class Computers
    {
        private static PersonalComputer pc;
        private static Laptop laptop;
        private static Server server;

        public static void Main()
        {
            CreateComputers();

            PreocessCommands();
        }

        private static void CreateComputers()
        {
            // Create Computers
            var manufacturer = Console.ReadLine();
            IComputersFactory computerFactory;
            if (manufacturer == "HP")
            {
                computerFactory = new HpComputersFactory();
            }
            else if (manufacturer == "Dell")
            {
                computerFactory = new DellComputersFactory();
            }
            else
            {
                // TODO: Exception?
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            pc = computerFactory.CreatePersonalComputer();

            laptop = computerFactory.CreateLaptop();

            server = computerFactory.CreateServer();
        }

        private static void PreocessCommands()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == null)
                {
                    break;
                }

                if (input.StartsWith("Exit"))
                {
                    break;
                }

                var cp = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (cp.Length != 2)
                {
                    throw new ArgumentException("Invalid command!");
                }

                // Preocess commands
                var commandName = cp[0];
                var commandArgument = int.Parse(cp[1]);

                if (commandName == "Charge")
                {
                    laptop.ChargeBattery(commandArgument);
                }
                else if (commandName == "Process")
                {
                    server.Process(commandArgument);
                }
                else if (commandName == "Play")
                {
                    pc.Play(commandArgument);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}

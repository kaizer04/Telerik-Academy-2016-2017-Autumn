﻿namespace Bunnies
{
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            var bunnies = new List<Bunny>
            {
                new Bunny
                {
                    Name = "Leonid",
                    Age = 1,
                    Type = Type.NotFluffy
                },
                new Bunny
                {
                    Name = "Rasputin",
                    Age = 2,
                    Type = Type.ALittleFluffy
                },
                new Bunny
                {
                    Name = "Tiberii",
                    Age = 3,
                    Type = Type.ALittleFluffy
                },
                new Bunny
                {
                    Name = "Neron",
                    Age = 1,
                    Type = Type.ALittleFluffy
                },
                new Bunny
                {
                    Name = "Klavdii",
                    Age = 3,
                    Type = Type.Fluffy
                },
                new Bunny
                {
                    Name = "Vespasian",
                    Age = 3,
                    Type = Type.Fluffy
                },
                new Bunny
                {
                    Name = "Domician",
                    Age = 4,
                    Type = Type.FluffyToTheLimit
                },
                new Bunny
                {
                    Name = "Tit",
                    Age = 2,
                    Type = Type.FluffyToTheLimit
                }
            };

            var consoleWriter = new ConsoleWriter();

            foreach (var bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);
            }

            // Create bunnies text file
            var bunniesFilePath = @"..\..\bunnies.txt";
            var fileStream = File.Create(bunniesFilePath);
            fileStream.Close();

            // Save bunnies to a text file
            using (var streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }
}
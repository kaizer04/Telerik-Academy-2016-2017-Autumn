namespace Computers.Logic.Manufacturers
{
    using System;
    using System.Collections.Generic;

    using ComputerTypes;
    using Cpus;
    using VideoCards;
    using HardDrives;

    public class HpComputersFactory : IComputersFactory
    {
        public Laptop CreateLaptop()
        {
            var videoCard = new ColorfulVideoCard();
            var ram = new Ram(4);

            var laptop = new Laptop(
                new Cpu64(2, ram, videoCard),
                ram,
                new[] { new SingleHardDrive(500) },
                videoCard,
                new LaptopBattery());

            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(2);
            var videoCard = new ColorfulVideoCard();

            var pc = new PersonalComputer(
                new Cpu32(2, ram, videoCard),
                ram,
                new[] { new SingleHardDrive(500) },
                videoCard);

            return pc;
        }

        public Server CreateServer()
        {
            var ram = new Ram(32);
            var videoCard = new MonochromeVideoCard();

            var server = new Server(
                new Cpu32(4, ram, videoCard),
                ram,
                new List<HardDrive> { new RaidArray(new List<HardDrive> { new SingleHardDrive(1000), new SingleHardDrive(1000) }) },
                videoCard);

            return server;
        }
    }
}
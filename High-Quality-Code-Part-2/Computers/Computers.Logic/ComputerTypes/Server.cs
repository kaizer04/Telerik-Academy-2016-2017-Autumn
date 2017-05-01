namespace Computers.Logic.ComputerTypes
{
    using System.Collections.Generic;

    using Cpus;
    using HardDrives;
    using VideoCards;

    public class Server : Computer
    {
        public Server(
            Cpu cpu,
            Ram ram,
            IEnumerable<HardDrive> hardDrives,
            VideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
        }
        
        public void Process(int data)
        {
            this.Ram.SaveValue(data);

            Cpu.SquareNumber();
        }
    }
}

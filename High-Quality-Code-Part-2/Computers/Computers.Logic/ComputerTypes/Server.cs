namespace Computers.Logic.ComputerTypes
{
    using System.Collections.Generic;

    using Cpus;
    using VideoCards;
    using HardDrives;

    public class Server : Computer
    {
        internal Server(
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

            // TODO: Fix it
            Cpu.SquareNumber();
        }
    }
}

namespace Computers.Logic.HardDrives
{
    using System.Collections.Generic;

    public abstract class HardDrive
    {
        public abstract int Capacity { get; }

        public abstract void SaveData(int address, string newData);

        public abstract string LoadData(int address);
    }
}
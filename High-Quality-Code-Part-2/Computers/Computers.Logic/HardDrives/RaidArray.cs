namespace Computers.Logic.HardDrives
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RaidArray : HardDrive
    {
        private const string HardDisksNotAvailableMessage = "No hard drive in the RAID array!";

        private List<HardDrive> hardDrives;
        
        public RaidArray(List<HardDrive> hardDrives)
        {
            this.hardDrives = hardDrives;
        }
        
        public override int Capacity
        {
            get
            {
                if (!this.hardDrives.Any())
                {
                    return 0;
                }

                return this.hardDrives.First().Capacity;
            }
        }

        public override void SaveData(int addr, string newData)
        {
            foreach (var hardDrive in this.hardDrives)
            {
                hardDrive.SaveData(addr, newData);
            }
        }

        public override string LoadData(int address)
        {
            if (!this.hardDrives.Any())
            {
                throw new ArgumentNullException(HardDisksNotAvailableMessage);
            }

            return this.hardDrives.First().LoadData(address);
        }
    }
}
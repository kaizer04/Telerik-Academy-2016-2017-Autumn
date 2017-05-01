﻿namespace Computers.Logic.Cpus
{
    using VideoCards;

    public class Cpu32 : Cpu
    {
        public Cpu32(byte numberOfCores, Ram ram, VideoCard videoCard)
            : base(numberOfCores, ram, videoCard)
        {
        }

        protected override int GetMaxValue()
        {
            return 500;
        }
    }
}
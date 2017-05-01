namespace Computers.Logic.Cpus
{
    public class Cpu32 : Cpu
    {
        const int MaxValue = 500;

        public Cpu32(byte numberOfCores)
            : base(numberOfCores)
        {
        }

        protected override int GetMaxValue()
        {
            return MaxValue;
        }
    }
}
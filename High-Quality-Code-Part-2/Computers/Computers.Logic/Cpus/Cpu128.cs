namespace Computers.Logic.Cpus
{
    public class Cpu128 : Cpu
    {
        const int MaxValue = 2000;

        public Cpu128(byte numberOfCores)
            : base(numberOfCores)
        {
        }
        
        protected override int GetMaxValue()
        {
            return MaxValue;
        }
    }
}

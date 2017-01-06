namespace ImplementTimer
{
    using System;
    using System.Threading;
                    
    public class Timer
    {
        private int count;
        private int interval; // in miliseconds
        private TimerEvent tE;
        private int ticks;

        //constructor with both thicks and interval in seconds
        public Timer(int count, int interval, TimerEvent TE)
        {
            this.Count = count;
            this.Interval = interval;
            this.tE = TE;
            this.ticks = 0;
        }

        //constructor with only interval in seconds and max thicks
        public Timer(int interval, TimerEvent TE)
            : this(int.MaxValue, interval, TE) { }

        //empty constructor - max thicks and 1 second interval
        public Timer(TimerEvent TE)
            : this(int.MaxValue, 1, TE) { }

        public int Interval
        {
            get
            {
                return this.interval;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Interval must be > 0 !");
                }
                this.interval = value * 1000;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Count must be > 0 !");
                }
                this.count = value;
            }
        }

        public void Run()
        {
            while (ticks < this.count)
            {
                Thread.Sleep(this.Interval);
                ticks++;
                tE();
            }
        }
    }
}
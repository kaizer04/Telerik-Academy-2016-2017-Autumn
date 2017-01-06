namespace ImplementTimer
{
    using System;
    using System.Threading;

    public delegate void TimerEvent();

    public class TimerTest
    {
        public static void Main()
        {
            TimerEvent te1 = new TimerEvent(ExecuteEach3Seconds);
            Timer tm1 = new Timer(3, te1);

            TimerEvent te2 = new TimerEvent(SecondExecuteEach5Seconds);
            Timer tm2 = new Timer(5, te2);

            Timer tm3 = new Timer(new TimerEvent(delegate () { Console.WriteLine("each second"); }));

            Thread timer1Thread = new Thread(new ThreadStart(tm1.Run));
            timer1Thread.Start();

            Thread timer2Thread = new Thread(new ThreadStart(tm2.Run));
            timer2Thread.Start();

            Thread timer3Thread = new Thread(new ThreadStart(tm3.Run));
            timer3Thread.Start();
        }

        private static void ExecuteEach3Seconds()
        {
            Console.WriteLine("every 3rd second");
        }

        private static void SecondExecuteEach5Seconds()
        {
            Console.WriteLine("every 5 seconds");
        }
    }
}
﻿namespace Computers.Logic.Cpus
{
    using System;

    public abstract class Cpu : IMotherboardComponent
    {
        private const string NumberTooHighMessage = "Number too high.";
        private const string NumberTooLowMessage = "Number too low.";
        private const string SquareInfoStringFormat = "Square of {0} is {1}.";

        private static readonly Random Random = new Random();
        
        private IMotherboard motherboard;
        
        public Cpu(byte numberOfCores)
        {
            this.NumberOfCores = numberOfCores;
        }

        private byte NumberOfCores { get; set; }

        public void AttachTo(IMotherboard motherboard)
        {
            this.motherboard = motherboard;
        }

        public void Rand(int a, int b)
        {
            int randomNumber = Random.Next(a, b + 1);

            this.motherboard.SaveRamValue(randomNumber);
        }

        public void SquareNumber()
        {
            var data = this.motherboard.LoadRamValue();
            if (data < 0)
            {
                this.motherboard.DrawOnVideoCard(NumberTooLowMessage);
            }
            else if (data > this.GetMaxValue())
            {
                this.motherboard.DrawOnVideoCard(NumberTooHighMessage);
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.motherboard.DrawOnVideoCard(string.Format(SquareInfoStringFormat, data, value));
            }
        }

        protected abstract int GetMaxValue();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Boombox
    {
        public bool Power;

        private int volume;
        private readonly int maxVolume = 9;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (Power == false)
                {
                    volume = 0;
                }
                else if (value >= maxVolume)
                {
                    volume = maxVolume;
                    Console.WriteLine("Volume is set to maximum > " + volume);

                }
                else if (value <= 0)
                {
                    volume = 0;
                    Console.WriteLine("Volume is set to minimum > " + volume);
                }
                else
                {
                    Console.WriteLine("Volume > " + value);
                }

            }
        }

        private readonly double maxFrequency = 26000.0;
        private readonly double minFrequency = 20000.0;
        private double frequency;
        public double Frequency
        {
            get { return frequency; }
            set
            {
                if (Power == false)
                {
                    frequency = 0;
                }
                else if (value >= maxFrequency)
                {
                    frequency = maxFrequency;
                    Console.WriteLine("Cannot search higher frequency > " + maxFrequency);
                }
                else if (value <= minFrequency)
                {
                    frequency = minFrequency;
                    Console.WriteLine("Cannot search lower frequency > " + minFrequency);
                }
                else
                {
                    Console.WriteLine("Frequency > " + value);
                }
            }

        }

        //default constructor
        public Boombox() { }

        public Boombox(bool power, int volume, double frequency)
        {
            Power = power;
            Volume = volume;
            Frequency = frequency;
        }

        public override string ToString()
        {
            return "Power: " + Power;
        }
    }
}

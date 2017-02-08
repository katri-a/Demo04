using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Speaker
    {
        private int volume;
        private readonly int maxVolume = 100;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= maxVolume)
                {
                    volume = maxVolume;
                    Console.WriteLine("-> Too much volume -  Amplifier volume is set to maximum: " + volume);

                }
                else if (value <= 0)
                {
                    volume = 0;
                    Console.WriteLine("-> Too low volume - Amplifier volume is set to minimum: " + volume);
                }
                else
                {
                    Console.WriteLine("-> Amplifier volume is set to: " + value);
                }    
               
            }
        }
    }
}

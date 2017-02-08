using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Boombox boombox = new Boombox();
            boombox.Power = true;
            boombox.Frequency = 24000.3;
            boombox.Volume = 5;
            Console.WriteLine(boombox.ToString() + "\n");

            Boombox boombox2 = new Boombox();
            boombox2.Power = true;
            boombox2.Frequency = 2000.3;
            boombox2.Volume = 14;
            Console.WriteLine(boombox2.ToString() + "\n");

            Boombox boombox3 = new Boombox();
            boombox3.Power = false;
            boombox3.Frequency = 24000.3;
            boombox3.Volume = 5;
            Console.WriteLine(boombox3.ToString() + "\n");
        }
    }
}

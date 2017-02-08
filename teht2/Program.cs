using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*yksinkertaisen vahvistimen toiminta, jolla voidaan kontrolloida äänenvoimakkuutta välillä 0-100*/

namespace teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Speaker volume = new Speaker();
            int luku;

            do
            {
                Console.Write("Change the volume > ");
                luku = int.Parse(Console.ReadLine());
                volume.Volume = luku;

            } while (luku != -5);
        }
    }
}

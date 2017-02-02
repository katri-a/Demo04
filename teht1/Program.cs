using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            int luku;
            do
            {
                Console.Write("Give a floor number (1-5) > ");
                luku = int.Parse(Console.ReadLine());
                elevator.Floor = luku;

                Console.WriteLine("Elevator is now in floor: " + elevator.Floor);
            } while (luku != 0);
        }
    }
}

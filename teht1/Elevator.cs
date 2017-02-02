using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Elevator
    {

        private int maxFloor = 5;
        private int minFloor = 1;
        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value >= minFloor && value <= maxFloor) floor = value;
              //  else if (value == 0)
              //      Console.WriteLine("Stop");
                else
                {
                    Console.WriteLine("Not a valid floor request");
                }
            }
        }
    }
}

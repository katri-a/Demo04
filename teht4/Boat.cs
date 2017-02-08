using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Boat : Vehicle
    {
        public string Type { get; set; }
        public int Seat { get;set;}

        public Boat()
        {

        }

        //constructor
        public Boat(string name, string color, int year, string model, string type, int seat)
            : base (name, color, year, model)
        {
            Type = type;
            Seat = seat;
        }

        public override string ToString()
        {
            return base.ToString() + " Type: " + Type + " Seats: " + Seat + "\n";
        }
    }
}

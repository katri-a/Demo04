using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Bike : Vehicle
    {
        public bool Gears { get; set; }
        public string Gearmodel { get; set; }

        public Bike()
        {
            //default
        }

        public Bike(string name, string color, int year, string model, bool gears, string gearmodel)
            : base (name, color, year, model)
        {
            Gears = gears;
            Gearmodel = gearmodel;
        }

        public override string ToString()
        {
            return base.ToString() + " GearWheels: " + Gears + " Gear name: " + Gearmodel + "\n";
        }
    }

}

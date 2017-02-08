using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Vehicle
    { 
        public string Name { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }

        //default constructor
        public Vehicle()
        {
        }

        //constructor for parameters
        public Vehicle(string name, string color, int year, string model)
        {
            Name = name;
            Color = color;
            Year = year;
            Model = model;
        }

        //method
        public override string ToString()
        {
            return "Name: " + Name + " Color: " + Color + " Model: " + Model + " Year: " + Year;
        }
    }
}

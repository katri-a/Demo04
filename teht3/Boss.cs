using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        //default constructor
        public Boss()
        {
        }

        //Constructor, Boss-luokan omat parametrit
        public Boss(string firstname, string lastname, string salary, string profession, string car, int bonus)
            : base(firstname, lastname, salary, profession)
            {
            Car = car;
            Bonus = bonus;
            }

        public override string ToString()
        {
            return base.ToString() + " Auto: " + Car + " Bonus: " + Bonus + " euroa";
        }
    }
}

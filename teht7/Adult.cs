using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7
{
    class Adult : Person
    {
        public string Cardnum { get; set; }

        //default
        public Adult() { }

        public Adult(string name, int age, string address, string phonenum, string cardnum)
            : base(name, age, address, phonenum)
        {
            Cardnum = cardnum;
        }

        public override string ToString()
        {
            return base.ToString() + "Cardnumber: " + Cardnum + "\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7
{
    class Junior : Person
    {
        public string Guardian { get; set; }

        //default
        public Junior()
        {

        }

        public Junior(string name, int age, string address, string phonenum, string guardian)
            : base(name, age, address, phonenum)
        {
            Guardian = guardian;
        }

        public override string ToString()
        {
            return base.ToString() + "Guardian: " + Guardian + "\n";
        }
    }
}

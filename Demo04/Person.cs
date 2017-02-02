using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNum { get; set; }

        public Person()
        {
        }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        protected void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }

        public override string ToString() //override olion oletus ToString, ylikirjoittaa kaikki objecti luokat
        {
            return FirstName + " " + LastName + " " + Address +  " " + Age + " " + PhoneNum + " ";
        }
    }
}

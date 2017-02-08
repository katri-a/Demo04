using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; }
        public string Profession { get; set; }

        // default constructor
        public Employee()
        {
        }

        // constructor takes parameters
        public Employee(string firstname, string lastname, string salary, string profession)
        {
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            Profession = profession;
        }

        public override string ToString()
        {
            return "Nimi: " + FirstName + " " + LastName + " Palkka: " + Salary + " euroa " + "Ammatti: " + Profession;
        }
    }
}

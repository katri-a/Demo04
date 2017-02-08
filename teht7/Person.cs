using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phonenum { get; set; }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 18) age = value;
                else
                {
                    Console.WriteLine("This person is underage:");
                    age = value;
                }
            }
        }

        //default console
        public Person()
        { }

        public Person(string name, int age, string address, string phonenum)
        {
            Name = name;
            Age = age;
            Address = address;
            Phonenum = phonenum;

        }

        public override string ToString()
        {
            return "Name: " + Name + "\n" + "Age: " + Age + "\n" + "Address: " + Address + "\n" + "Phonenumber: " + Phonenum + "\n";
        }

    }
}

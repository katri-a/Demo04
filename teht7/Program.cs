using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult adult = new Adult();
            adult.Name = "Heli Helikopteri";
            adult.Age = 28;
            adult.Address = "Jokutie 12  40100 Jyväskylä";
            adult.Phonenum = "3434989438";
            adult.Cardnum = "23425455";
            Console.WriteLine(adult.ToString());

            Junior junior = new Junior();
            junior.Name = "Tatu Helikopteri";
            junior.Age = 11;
            junior.Phonenum = "5054050303";
            junior.Guardian = "Heli Helikopteri";
            Console.WriteLine(junior.ToString());
        }
    }
}

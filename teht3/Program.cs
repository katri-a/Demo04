using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Saku";
            employee.LastName = "Sammakko";
            employee.Profession = "kirjanpitäjä";
            employee.Salary = "2000";
            Console.WriteLine(employee.ToString());

            Boss boss = new Boss();
            boss.FirstName = "Iines";
            boss.LastName = "Ankka";
            boss.Profession = "Rehtori";
            boss.Salary = "4000";
            boss.Car = "Mersu";
            boss.Bonus = 1000;
            Console.WriteLine(boss.ToString());

            employee.FirstName = "Saku";
            employee.LastName = "Sammakko";
            employee.Profession = "kirjanpitäjä";
            employee.Salary = "3000";
            Console.WriteLine(employee.ToString());

        }
    }
}

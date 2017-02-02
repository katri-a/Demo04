using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one student
            Student student = new Student();
            student.FirstName = "Jake";
            student.LastName = "Jokunen";
            student.Address = "Rajakatu 1";
            student.Age = 22;
            student.PhoneNum = "35754466";
            student.StudentID = "K2263";
            Console.WriteLine(student.ToString());

            Teacher teacher = new Teacher("Kirsi", "Kernel", "D566");
            teacher.Age = 45;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNum = "56732222";
            Console.WriteLine(teacher.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();

            /*student.PersonMethod(); 
             aliluokka voi käyttää yliluokan metodeja jos ei ole suojattu, jos protected niin voi käyttää luokasta,
             mutta ei oliosta, koska olio ei ole aliluokan sisällä*/

        }
    }
}

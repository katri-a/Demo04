using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Teacher : Person
    {
        public string Room { get; set; }
        public Teacher()
        {
        }
        public Teacher(string firstname, string lastname, string room)
            : base(firstname, lastname) //yliluokkaan
        {
            Room = room;
        }

        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        public override string ToString()
        {
            // Person luokan To.String (eli mitä kirjoitettu Person-luokassa To.String metodiin) + Room
            return base.ToString() + Room;
        }
    }
}




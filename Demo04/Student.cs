﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Student : Person
    {
        public string StudentID { get; set; }

        // default constructor
        public Student()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Student(string firstname, string lastname, string studentID)
            : base(firstname, lastname)
        {
            StudentID = studentID;
        }

        // just one method what Student can do
        public void StudentMethod()
        {
            Console.WriteLine("This method belongs to Student!");
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}

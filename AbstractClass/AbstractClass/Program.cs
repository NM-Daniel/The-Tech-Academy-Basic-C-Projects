﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee object is instantiated and given values for its properties
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            //the Method SayName from the employee class is called
            employee.SayName();

            Console.ReadLine();
        }
    }
}

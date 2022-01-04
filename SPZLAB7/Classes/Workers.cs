﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZLAB7.Classes
{
    public class Workers
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public Workers(string name, string surname, int salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }
        public Workers() { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LAB_4
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salery { get; set; }

        public Employee(int _id, string _name, string _gender, decimal _salery)
        {
            ID = _id;
            Name = _name;
            Gender = _gender;
            Salery = _salery;
        }
    }
}

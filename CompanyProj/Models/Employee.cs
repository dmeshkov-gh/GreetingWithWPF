using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyProj.Models
{
    class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public Department Department { get; set; }

        public Employee()
        {

        }
        public Employee(string name, string lastName, int age, int salary, Department department)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Salary = salary;
            Department = department;
        }

        public override string ToString()
        {
            return $"{Name} {LastName}, {Age}";
        }
    }
}

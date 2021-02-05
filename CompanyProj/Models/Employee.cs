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

        public Employee()
        {

        }
        public Employee(string name, string lastName, int age, int salary)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name} {LastName}, Age: {Age}, Salary: {Salary}";
        }
    }
}

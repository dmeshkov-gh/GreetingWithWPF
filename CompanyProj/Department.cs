using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyProj
{
    class Department
    {
        private List<Employee> employees = new List<Employee>();
        public string Name { get; set; }
        public List<Employee> Employees { get => employees; set => employees = value; }

        public Department(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

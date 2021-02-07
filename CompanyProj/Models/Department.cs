using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CompanyProj.Models
{
    class Department
    {
        private List<Employee> employees = new List<Employee>();
        public string Name { get; set; }
        public ObservableCollection<Employee> Employees { get; set; } = new();

        public Department()
        {

        }
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

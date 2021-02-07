using CompanyProj.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;

namespace CompanyProj.ViewModels
{

    class MainWindowViewModel
    {
        public ObservableCollection<Department> Departments { get; set; }

        string[] names = new string[] { "Dmitry", "Ivan", "Pavel", "Sergey", "Alex", "Leo", "Petr" };
        string[] lastNames = new string[] { "Ivanov", "Petrov", "Sergeev", "Pustovoy", "Markov", "Stepanov", "Grigoriev", "Meshkov", "Danilov" };

        public MainWindowViewModel()
        {
            Random r = new Random();
             var departments = Enumerable.Range(1, 5)
                .Select(d => new Department
                {
                    Name = $"Departament # {d}",
                    Employees = Enumerable.Range(1, 3)
                        .Select(e => new Employee
                        {
                            Name = names[r.Next(0, names.Length)],
                            LastName = lastNames[r.Next(0, lastNames.Length)],
                            Age = r.Next(18, 51),
                            Salary = r.Next(5000, 10000),
                        })
                        .ToList()
                })
                .ToList();

            Departments = new(departments);
        }
    }
}

using CompanyProj.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CompanyProj.ViewModels
{

    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Department _selectedDepartment;
        private Employee _selectedEmployee;
        public ObservableCollection<Department> Departments { get; set; }

        public Department SelectedDepartment
        {
            get => _selectedDepartment;
            set
            {
                _selectedDepartment = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedDepartment"));

                SelectedEmployee = null;
            }
        }

        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                _selectedEmployee = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedEmployee"));
            }
        }

        string[] names = new string[] { "Dmitry", "Ivan", "Pavel", "Sergey", "Alex", "Leo", "Petr" };
        string[] lastNames = new string[] { "Ivanov", "Petrov", "Sergeev", "Pustovoy", "Markov", "Stepanov", "Grigoriev", "Meshkov", "Danilov" };

        public MainWindowViewModel()
        {
            Random r = new Random();
             var departments = Enumerable.Range(1, 5)
                .Select(d => new Department
                {
                    Name = $"Departament # {d}",
                    Employees = new(Enumerable.Range(1, 3)
                        .Select(e => new Employee
                        {
                            Name = names[r.Next(0, names.Length)],
                            LastName = lastNames[r.Next(0, lastNames.Length)],
                            Age = r.Next(18, 51),
                            Salary = r.Next(5000, 10000),
                            Department = SelectedDepartment
                        })
                        .ToList())
                })
                .ToList();

            Departments = new(departments);
        }

        public void AddNewDepartment()
        {
            var department = new Department
            {
                Name = $"Departament # {Departments.Count + 1}"
            };
            Departments.Add(department);
            SelectedDepartment = department;
        }

        public void RemoveSelectedDepartment()
        {
            if (SelectedDepartment is null) return;
            Departments.Remove(SelectedDepartment);
            SelectedDepartment = null;
        }
    }
}

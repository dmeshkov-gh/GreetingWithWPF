using CompanyProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompanyProj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        List<Department> departments = new List<Department>();

        string[] names = new string[] { "Dmitry", "Ivan", "Pavel", "Sergey", "Alex", "Leo", "Petr" };
        string[] lastNames = new string[] { "Ivanov", "Petrov", "Sergeev", "Pustovoy", "Markov", "Stepanov", "Grigoriev", "Meshkov", "Danilov" };

        public MainWindow()
        {
            InitializeComponent();
            CreateDepartments();
        }

        private void CreateDepartments()
        {
            departments = Enumerable.Range(1, 5)
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

            listDepartments.ItemsSource = departments;
        }

        private void listDepartments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedDepartment = departments?.Where(x => x == listDepartments.SelectedItem).FirstOrDefault();
            listEmployees.ItemsSource = selectedDepartment?.Employees;
        }

        private void AddEmployee_btn_Click(object sender, RoutedEventArgs e)
        {
            Department selectedDepartment = (Department)listDepartments.SelectedItem;
            selectedDepartment?.Employees.Add(new Employee(names[r.Next(0, names.Length)], lastNames[r.Next(0, lastNames.Length)],
                        r.Next(18, 51), r.Next(5000, 10000)));
        }

        private void RemoveEmployee_btn_Click(object sender, RoutedEventArgs e)
        {
            Department selectedDepartment = (Department)listDepartments.SelectedItem;
            Employee selectedEmployee = (Employee)listEmployees.SelectedItem;
            selectedDepartment?.Employees.Remove(selectedEmployee);
        }

        private void Update()
        {
            foreach (var department in departments)
                listEmployees.ItemsSource = department.Employees;
        }

        private void AddDepartment_btn_Click(object sender, RoutedEventArgs e)
        {
            departments.Add(new Department($"Departament # {departments.Count + 1}"));
        }

        private void TransferEmployee_btn_Click(object sender, RoutedEventArgs e)
        {
            //Department selectedDepartment = (Department)listDepartments.SelectedItem;
            //Employee selectedEmployee = (Employee)listEmployees.SelectedItem;

            //DepartmentWindow departmentWindow = new DepartmentWindow(departments, selectedEmployee);
            //departmentWindow.Show();

            //selectedDepartment?.Employees.Remove(selectedEmployee);
        }
    }
}

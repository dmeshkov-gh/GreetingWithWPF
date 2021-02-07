using CompanyProj.Models;
using CompanyProj.ViewModels;
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
        }

        //private void OnAddEmployee(object sender, RoutedEventArgs e)
        //{
        //    Department selectedDepartment = (Department)listDepartments.SelectedItem;
        //    selectedDepartment?.Employees.Add(new Employee(names[r.Next(0, names.Length)], lastNames[r.Next(0, lastNames.Length)],
        //                r.Next(18, 51), r.Next(5000, 10000)));
        //}

        private void OnAddEmployeeClick(object sender, RoutedEventArgs e)
        {      
        }

        //private void RemoveEmployee_btn_Click(object sender, RoutedEventArgs e)
        //{
        //    Department selectedDepartment = (Department)listDepartments.SelectedItem;
        //    Employee selectedEmployee = (Employee)listEmployees.SelectedItem;
        //    selectedDepartment?.Employees.Remove(selectedEmployee);
        //}

        private void AddDepartment_btn_Click(object sender, RoutedEventArgs e)
        {
            var model = (MainWindowViewModel)DataContext;

            model.Departments.Add(new Department
            {
                Name = $"Departament # {model.Departments.Count + 1}"
            });
        }

        //private void TransferEmployee_btn_Click(object sender, RoutedEventArgs e)
        //{
        //Department selectedDepartment = (Department)listDepartments.SelectedItem;
        //Employee selectedEmployee = (Employee)listEmployees.SelectedItem;

        //DepartmentWindow departmentWindow = new DepartmentWindow(departments, selectedEmployee);
        //departmentWindow.Show();

        //selectedDepartment?.Employees.Remove(selectedEmployee);
        //}
    }
}

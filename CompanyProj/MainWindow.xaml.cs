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

        private void AddDepartment_Click(object sender, RoutedEventArgs e)
        {
            var model = (MainWindowViewModel)DataContext;

            model.Departments.Add(new Department
            {
                Name = $"Departament # {model.Departments.Count + 1}"
            });
        }

        private void RemoveDepartment_Click(object sender, RoutedEventArgs e)
        {
            var model = (MainWindowViewModel)DataContext;

            var selected_department = (Department)Departments.SelectedItem;
            if (selected_department is null) return;

            model.Departments.Remove(selected_department);
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            var model = (MainWindowViewModel)DataContext;

            
        }

    }
}

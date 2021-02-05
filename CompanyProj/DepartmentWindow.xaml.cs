using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CompanyProj
{
    /// <summary>
    /// Interaction logic for DepartmentWindow.xaml
    /// </summary>
    public partial class DepartmentWindow : Window
    {
        Employee _selectedEmployee;
        //public DepartmentWindow(List<Department> departments, Employee selectedEmployee)
        //{
        //    InitializeComponent();
        //    listDepartments.ItemsSource = departments;
        //    _selectedEmployee = selectedEmployee;
        //}

        private void listDepartments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var departmentToTransfer = (Department)listDepartments.SelectedItem;
            departmentToTransfer.Employees.Add(_selectedEmployee);
        }
    }
}

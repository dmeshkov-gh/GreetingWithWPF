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

            model.AddNewDepartment();
        }

        private void RemoveDepartment_Click(object sender, RoutedEventArgs e)
        {
            var model = (MainWindowViewModel)DataContext;

            model.RemoveSelectedDepartment();
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            var model = (MainWindowViewModel)DataContext;


        }

    }
}

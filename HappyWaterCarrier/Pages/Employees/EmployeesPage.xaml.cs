using HappyWaterCarrier.Database;
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

namespace HappyWaterCarrier.Pages.Employees
{
    /// <summary>
    /// Interaction logic for EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        private EmployeesPageViewModel vm;
        public EmployeesPage()
        {
            InitializeComponent();
            vm = new EmployeesPageViewModel();
            DataContext = vm;
            vm.DataGridUpdateRequested += Vm_DataGridUpdateRequested;
        }

        private void Vm_DataGridUpdateRequested(object sender, EventArgs e)
        {
            dataGrid.ItemsSource = vm.employees;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.SelectedEmployees = dataGrid.SelectedItems.Cast<Сотрудник>().ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            dataGrid.ItemsSource = vm.employees;
        }
    }
}

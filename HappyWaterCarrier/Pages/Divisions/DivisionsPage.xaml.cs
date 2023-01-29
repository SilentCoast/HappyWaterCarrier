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

namespace HappyWaterCarrier.Pages.Divisions
{
    /// <summary>
    /// Interaction logic for DivisionsPage.xaml
    /// </summary>
    public partial class DivisionsPage : Page
    {
        public DivisionsPageViewModel vm;
        public DivisionsPage()
        {
            InitializeComponent();
            vm = new DivisionsPageViewModel();
            DataContext= vm;
            
            vm.DataGridUpdateRequested += Vm_DataGridUpdateRequested;
        }

        private void Vm_DataGridUpdateRequested(object sender, EventArgs e)
        {
            //update datagrid
            dataGrid.ItemsSource = vm.divisions;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //update selectedItems in vm
            vm.SelectedDivisions = dataGrid.SelectedItems.Cast<Подразделение>().ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //update datagrid
            dataGrid.ItemsSource = vm.divisions;
        }
    }
}

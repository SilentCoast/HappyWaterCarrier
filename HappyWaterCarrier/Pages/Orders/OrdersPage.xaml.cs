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

namespace HappyWaterCarrier.Pages.Orders
{
    /// <summary>
    /// Interaction logic for OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
            var vm = new OrdersPageViewModel();
            DataContext = vm;
            vm.DataGridUpdateRequested += Vm_DataGridUpdateRequested;
            
        }

        private void Vm_DataGridUpdateRequested(object sender, EventArgs e)
        {
            dataGrid.ItemsSource = ((OrdersPageViewModel)DataContext).orders;
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            dataGrid.ItemsSource = ((OrdersPageViewModel)DataContext).orders;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ((OrdersPageViewModel)DataContext).SelectedOrders = dataGrid.SelectedItems.Cast<Заказ>().ToList();
            
        }

    }
}

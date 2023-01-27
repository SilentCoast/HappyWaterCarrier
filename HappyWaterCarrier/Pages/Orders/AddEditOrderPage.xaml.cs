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
    /// Interaction logic for AddEditOrderPage.xaml
    /// </summary>
    public partial class AddEditOrderPage : Page
    {
        public AddEditOrderPage(Заказ order)
        {
            InitializeComponent();
            DataContext = new AddEditOrderPageViewModel(order);
            
        }
    }
}

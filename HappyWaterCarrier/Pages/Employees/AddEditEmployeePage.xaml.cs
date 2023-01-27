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
    /// Interaction logic for AddEditEmployeePage.xaml
    /// </summary>
    public partial class AddEditEmployeePage : Page
    {
        public AddEditEmployeePage(Сотрудник employee)
        {
            InitializeComponent();
            DataContext = new AddEditEmployeePageViewModel(employee);
        }
    }
}

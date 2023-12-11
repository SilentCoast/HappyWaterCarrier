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
    /// Interaction logic for AddEditDivisionPage.xaml
    /// </summary>
    public partial class AddEditDivisionPage : Page
    {
        public AddEditDivisionPage(Подразделение division)
        {
            InitializeComponent();
            var vm = new AddEditDivisionPageViewModel(division);
            DataContext= vm;
        }
    }
}

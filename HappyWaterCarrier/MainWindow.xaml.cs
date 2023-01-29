using HappyWaterCarrier.Classes;
using HappyWaterCarrier.Database;
using HappyWaterCarrier.Pages;
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

namespace HappyWaterCarrier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            FrameManager.Frame = frame;   
            vm = new MainWindowViewModel();
            DataContext= vm;
        }
        private void frame_ContentRendered(object sender, EventArgs e)
        {
            if(frame.CanGoBack)
            {
                vm.IsGoBackVisible = Visibility.Visible;
            }
            else
            {
                vm.IsGoBackVisible = Visibility.Hidden;
            }
        }
    }
}

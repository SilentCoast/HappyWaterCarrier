using HappyWaterCarrier.Classes;
using System;
using System.Windows;

namespace HappyWaterCarrier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainWindowViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            FrameManager.Frame = frame;
            vm = new MainWindowViewModel();
            DataContext = vm;
        }
        private void frame_ContentRendered(object sender, EventArgs e)
        {
            if (frame.CanGoBack)
            {
                btnGoBack.Visibility = Visibility.Visible;
            }
            else
            {
                btnGoBack.Visibility = Visibility.Hidden;
            }
        }
    }
}

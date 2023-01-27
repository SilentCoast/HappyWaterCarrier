using HappyWaterCarrier.Classes;
using HappyWaterCarrier.Database;
using HappyWaterCarrier.Pages;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HappyWaterCarrier
{
    [AddINotifyPropertyChangedInterface]
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            //to get database loaded
            WorkWithDB.GetЗаказы();

            FrameManager.Frame.Navigate(new MainMenuPage());
        }
        private RelayCommand frameGoBack;
        public RelayCommand FrameGoBack => frameGoBack ?? (frameGoBack = new RelayCommand(g =>
        {
            FrameManager.Frame.GoBack();
        }));
        public Visibility IsGoBackVisible { get; set; } = Visibility.Hidden;

    }
}

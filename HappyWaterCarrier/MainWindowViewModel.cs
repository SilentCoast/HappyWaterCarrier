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
using System.Windows.Controls.Primitives;

namespace HappyWaterCarrier
{
    //TODO: check if database is exist and create if its not
    //TODO: add scrolview to pages
    [AddINotifyPropertyChangedInterface]
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            //to get database loaded
            WorkWithDB.GetЗаказы();

            FrameManager.Frame.Navigate(new MainMenuPage());
            PopupManager.IsOpenChanged += PopupManager_IsOpenChanged;
        }
        public PopupData popupData { get; set; }
        private void PopupManager_IsOpenChanged(object sender, EventArgs e)
        {
            popupData = ((PopupData)sender);
        }
        private RelayCommand frameGoBack;
        public RelayCommand FrameGoBack => frameGoBack ?? (frameGoBack = new RelayCommand(g =>
        {
            FrameManager.Frame.GoBack();
        }));
        public Visibility IsGoBackVisible { get; set; } = Visibility.Hidden;

    }
}

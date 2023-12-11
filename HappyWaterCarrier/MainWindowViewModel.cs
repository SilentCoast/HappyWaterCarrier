using HappyWaterCarrier.Classes;
using HappyWaterCarrier.Database;
using HappyWaterCarrier.Pages;
using PropertyChanged;
using System;
using System.Windows;

namespace HappyWaterCarrier
{
    //TODO: add scrolview to pages

    [AddINotifyPropertyChangedInterface]
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            WorkWithDB.Initialize();

            FrameManager.Frame.Navigate(new MainMenuPage());
            PopupManager.IsOpenChanged += PopupManager_IsOpenChanged;
        }
        public PopupData PopupData { get; set; }
        private void PopupManager_IsOpenChanged(object sender, EventArgs e)
        {
            PopupData = ((PopupData)sender);
        }
        private RelayCommand frameGoBack;
        public RelayCommand FrameGoBack => frameGoBack ?? (frameGoBack = new RelayCommand(g =>
        {
            FrameManager.Frame.GoBack();
        }));

    }
}

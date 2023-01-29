using HappyWaterCarrier.Classes;
using HappyWaterCarrier.Database;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HappyWaterCarrier.Pages.Orders
{
    public class OrdersPageViewModel
    {
        public Заказ SelectedOrder { get; set; }
        public List<Заказ> SelectedOrders { get; set; }
        public List<Заказ> orders=> WorkWithDB.GetЗаказы();
        public event EventHandler DataGridUpdateRequested;
        
        private RelayCommand addOrder;
        public RelayCommand AddOrder =>addOrder?? (addOrder = new RelayCommand(obj =>
        {
            FrameManager.Frame.Navigate(new AddEditOrderPage(new Заказ()));
        }));
        private RelayCommand removeOrders;
        public RelayCommand RemoveOrders => removeOrders ?? (removeOrders = new RelayCommand(Grisha =>
        {
            WorkWithDB.RemoveOrders(SelectedOrders);
            
            if (DataGridUpdateRequested != null)
            {
                DataGridUpdateRequested(this, EventArgs.Empty);
            }
            PopupManager.OpenMessagePopup("Изменения сохранены");
        }));
        private RelayCommand editOrder;
        public RelayCommand EditOrder => editOrder ?? (editOrder = new RelayCommand(obj =>
        {
            FrameManager.Frame.Navigate(new AddEditOrderPage(SelectedOrder));
        }));

    }
}

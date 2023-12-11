using HappyWaterCarrier.Classes;
using HappyWaterCarrier.Database;
using PropertyChanged;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace HappyWaterCarrier.Pages.Orders
{
    [AddINotifyPropertyChangedInterface]
    public class AddEditOrderPageViewModel
    {
        public Заказ order { get; set; }
        public List<Сотрудник> Employees => WorkWithDB.GetEmployees();
        public Сотрудник selectedEmployee { get; set; }
        public AddEditOrderPageViewModel(Заказ order)
        {
            this.order = order;
            selectedEmployee = order.Сотрудник;

        }
        private RelayCommand saveOrder;
        public RelayCommand SaveOrder => saveOrder ?? (saveOrder = new RelayCommand(p =>
        {
            StringBuilder errorMessage = new StringBuilder(); ;
            if (order.Номер == null)
            {
                errorMessage.AppendLine("Номер не может быть пустым");
            }
            if (order.Название_товара == null)
            {
                errorMessage.AppendLine("Название товара не может быть пустым");
            }
            if (selectedEmployee == null)
            {
                errorMessage.AppendLine("Выберите сотрудника");
            }
            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage.ToString());
                return;
            }
            order.Сотрудник = selectedEmployee;
            if (WorkWithDB.PutЗаказ(order))
            {
                FrameManager.Frame.GoBack();
                PopupManager.OpenMessagePopup("Изменения сохранены");
            }
            else
            {
                PopupManager.OpenErrorPopup("Что-то пошло не так, попробуйте снова.\nЕсли ошибка сохранится, обратитесь в поддержку");
            }
        }));

    }
}

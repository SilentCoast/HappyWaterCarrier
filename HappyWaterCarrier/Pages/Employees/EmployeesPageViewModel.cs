using HappyWaterCarrier.Classes;
using HappyWaterCarrier.Database;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HappyWaterCarrier.Pages.Employees
{
    public class EmployeesPageViewModel
    {
        public event EventHandler DataGridUpdateRequested;
        public List<Сотрудник> employees => WorkWithDB.GetEmployees();
        public Сотрудник SelectedEmployee { get; set; }
        public List<Сотрудник> SelectedEmployees { get; set; }
        private RelayCommand addEmployee;
        public RelayCommand AddEmployee => addEmployee ?? (addEmployee = new RelayCommand(o =>
        {
            FrameManager.Frame.Navigate(new AddEditEmployeePage(new Сотрудник()));
        }));
        
        private RelayCommand removeEmployee;
        public RelayCommand RemoveEmployee => removeEmployee ?? (removeEmployee = new RelayCommand(o =>
        {
            StringBuilder stringBuilder= new StringBuilder();
            List<Заказ> dependedOrdersToDelete = new List<Заказ>();
            SelectedEmployees.ForEach(e =>
            {
                if (e.Заказ.Count() > 0)
                {
                    dependedOrdersToDelete = e.Заказ.ToList();
                    stringBuilder.AppendLine("Сотрудник " + e.Фамилия + " имеет зависимые заказы:\n");
                    e.Заказ.ToList().ForEach(p =>
                    {
                        stringBuilder.AppendLine($"Номер: {p.Номер}, Название товара:{p.Название_товара}");
                    });
                    stringBuilder.AppendLine("\n");
                }
            });
            if (stringBuilder.Length > 0)
            {
                stringBuilder.AppendLine("\nУдалить эти заказы?\nДа - будут удалены сотрудники и связанные с ними заказы\n" +
                    "Нет - будут удалены только сотрудники\n");

                MessageBoxResult result = MessageBox.Show(stringBuilder.ToString(), "Обнаружены зависимые заказы", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                {
                    WorkWithDB.RemoveEmployees(SelectedEmployees);
                }
                else if (result == MessageBoxResult.Yes)
                {
                    WorkWithDB.RemoveEmployees(SelectedEmployees);
                    WorkWithDB.RemoveOrders(dependedOrdersToDelete);

                }
                else if (result != MessageBoxResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                WorkWithDB.RemoveEmployees(SelectedEmployees);
            }


            if (DataGridUpdateRequested!= null)
            {
                DataGridUpdateRequested(this, EventArgs.Empty);
            }
            PopupManager.OpenMessagePopup("Изменения сохранены");
        }));
        private RelayCommand editEmployee;
        public RelayCommand EditEmployee => editEmployee ?? (editEmployee = new RelayCommand(o =>
        {
            FrameManager.Frame.Navigate(new AddEditEmployeePage(SelectedEmployee));
        }));
    }
}

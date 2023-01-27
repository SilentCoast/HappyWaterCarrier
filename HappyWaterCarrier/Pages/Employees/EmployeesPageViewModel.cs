using HappyWaterCarrier.Classes;
using HappyWaterCarrier.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyWaterCarrier.Pages.Employees
{
    //TODO: when deleting employee ask also delete orders with that employee, add not null to order.employee
    public class EmployeesPageViewModel
    {
        public event EventHandler DataGridUpdateRequested;
        public List<Сотрудник> employees => WorkWithDB.GetEmployees();
        public List<Сотрудник> SelectedEmployees { get; set; }
        private RelayCommand addEmployee;
        public RelayCommand AddEmployee => addEmployee ?? (addEmployee = new RelayCommand(o =>
        {
            FrameManager.Frame.Navigate(new AddEditEmployeePage(new Сотрудник()));
        }));
        
        private RelayCommand removeEmployee;
        public RelayCommand RemoveEmployee => removeEmployee ?? (removeEmployee = new RelayCommand(o =>
        {
            WorkWithDB.RemoveEmployees(SelectedEmployees);
            if(DataGridUpdateRequested!= null)
            {
                DataGridUpdateRequested(this, EventArgs.Empty);
            }
            PopupManager.IsOpen = true;
        }));
    }
}

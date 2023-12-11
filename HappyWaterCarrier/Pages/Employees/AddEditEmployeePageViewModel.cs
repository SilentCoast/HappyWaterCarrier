using HappyWaterCarrier.Classes;
using HappyWaterCarrier.Database;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyWaterCarrier.Pages.Employees
{
    public class AddEditEmployeePageViewModel
    {
        public Сотрудник employee { get; set; }
        public AddEditEmployeePageViewModel(Сотрудник employee)
        {
            this.employee = employee;
        }
        public List<Пол> Genders => WorkWithDB.GetGenders();
        public List<Подразделение> Divisions => WorkWithDB.GetПодразделения();
        private RelayCommand saveEmployee;
        public RelayCommand SaveEmployee => saveEmployee ?? (saveEmployee = new RelayCommand(o =>
        {
            if (WorkWithDB.PutEmployee(employee))
            {
                FrameManager.Frame.GoBack();
                PopupManager.OpenMessagePopup("Изменения сохранены");
            }
           
        }));
    }
}

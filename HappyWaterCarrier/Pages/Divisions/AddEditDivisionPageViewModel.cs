using HappyWaterCarrier.Classes;
using HappyWaterCarrier.Database;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HappyWaterCarrier.Pages.Divisions
{
    [AddINotifyPropertyChangedInterface]
    public class AddEditDivisionPageViewModel
    {
        public Подразделение division { get; set; }
        public AddEditDivisionPageViewModel(Подразделение division)
        {
            this.division = division;
        }

        public List<Сотрудник> employees => WorkWithDB.GetEmployees();
        
        private RelayCommand saveDivision;
        public RelayCommand SaveDivision => saveDivision ?? (saveDivision = new RelayCommand(p =>
        {
            if (WorkWithDB.PutDivision(division))
            {
                FrameManager.Frame.GoBack();
                PopupManager.OpenMessagePopup("Изменения сохранены");
            }
            else
            {
                PopupManager.OpenErrorPopup("Ошибка");
            }
        }));
    }
}

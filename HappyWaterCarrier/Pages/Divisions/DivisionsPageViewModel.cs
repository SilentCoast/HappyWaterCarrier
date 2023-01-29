using HappyWaterCarrier.Classes;
using HappyWaterCarrier.Database;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HappyWaterCarrier.Pages.Divisions
{
    [AddINotifyPropertyChangedInterface]
    public class DivisionsPageViewModel
    {
        public List<Подразделение> SelectedDivisions { get; set; }
        public List<Подразделение> divisions => WorkWithDB.GetПодразделения();
        public event EventHandler DataGridUpdateRequested;
        private RelayCommand addDivision;
        public RelayCommand AddDivision => addDivision ?? (addDivision = new RelayCommand(obj =>
        {
            FrameManager.Frame.Navigate(new AddEditDivisionPage(new Подразделение()));
        }));
        private RelayCommand removeDivisions;
        public RelayCommand RemoveOrders => removeDivisions ?? (removeDivisions = new RelayCommand(Grisha =>
        {
            WorkWithDB.RemoveDvisions(SelectedDivisions);

            if (DataGridUpdateRequested != null)
            {
                DataGridUpdateRequested(this, EventArgs.Empty);
            }
            PopupManager.OpenMessagePopup("Изменения сохранены");
        }));
    }
}

using HappyWaterCarrier.Classes;
using HappyWaterCarrier.Pages.Divisions;
using HappyWaterCarrier.Pages.Employees;
using HappyWaterCarrier.Pages.Orders;

namespace HappyWaterCarrier.Pages
{
    public class MainMenuPageViewModel
    {
        private RelayCommand goToOrders;
        public RelayCommand GoToOrders => goToOrders ?? (goToOrders = new RelayCommand(p =>
        {
            FrameManager.Frame.Navigate(new OrdersPage());
        }));
        private RelayCommand goToEmployees;
        public RelayCommand GoToEmployees => goToEmployees ?? (goToEmployees = new RelayCommand(p =>
        {
            FrameManager.Frame.Navigate(new EmployeesPage());
        }));
        private RelayCommand goToDivisions;
        public RelayCommand GoToDivisions => goToDivisions ?? (goToDivisions = new RelayCommand(p =>
        {
            FrameManager.Frame.Navigate(new DivisionsPage());
        }));
    }
}

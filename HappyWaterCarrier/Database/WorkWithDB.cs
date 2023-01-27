using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyWaterCarrier.Database
{
    public static class WorkWithDB
    {
        public static HappyWaterCarrierEntities db = new HappyWaterCarrierEntities();
        public static List<Заказ> GetЗаказы()
        {
            return db.Заказ.ToList();
        }
        public static bool PutЗаказ(Заказ zakaz)
        {
            try
            {
                db.Заказ.AddOrUpdate(zakaz);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public static bool RemoveOrders(List<Заказ> orders)
        {
            try
            {
                db.Заказ.RemoveRange(orders);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<Сотрудник> GetEmployees()
        {
            return db.Сотрудник.ToList();
        }
        public static bool PutEmployee(Сотрудник Employee)
        {
            try
            {
                db.Сотрудник.AddOrUpdate(Employee);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public static bool RemoveEmployees(List<Сотрудник> employees)
        {
            try
            {
                db.Сотрудник.RemoveRange(employees);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<Пол> GetGenders()
        {
            return db.Пол.ToList();
        }
        public static List<Подразделение> GetПодразделения()
        {
            return db.Подразделение.ToList();
        }

    }
}

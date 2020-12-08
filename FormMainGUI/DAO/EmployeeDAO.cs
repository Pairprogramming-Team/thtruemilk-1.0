using FormMainGUI.ModelDB;
using FormMainGUI.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FormMainGUI.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeDAO();
                return instance;
            }
            set => instance = value;
        }

        private EmployeeDAO() { }

        public object loadListEmployee()
        {
            var db = DataProvider.Ins.DB;
            var result = (from c in db.Employees
                          select new
                          {
                              EmployeeID = c.EmployeeID,
                              Name = c.Name,
                              Phone = c.Phone,
                              Sex = c.Sex,
                              YearOfBirth = c.YearOfBirth,
                              Address = c.Address,
                          }).ToList();

            return result;
        }
 
        public bool addEmployee(Employee employee)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool updateEmployee(Employee employee)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                Employee emp = db.Employees.Where(x => x.EmployeeID == employee.EmployeeID).Select(x => x).FirstOrDefault();
                emp.Name = employee.Name;
                emp.Phone = employee.Phone;
                emp.Sex = employee.Sex;
                emp.YearOfBirth = employee.YearOfBirth;
                emp.Address = employee.Address;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool removeEmployee(string employeeId)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                Employee emp = db.Employees.Where(x => x.EmployeeID == employeeId).FirstOrDefault();
                db.Employees.Remove(emp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

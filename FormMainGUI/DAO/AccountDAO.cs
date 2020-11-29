using FormMainGUI.ModelDB;
using FormMainGUI.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FormMainGUI.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            set => instance = value;
        }

        private AccountDAO() { }

        public Account isLogin(string username, string password)
        {
            try
            {
                var account = DataProvider.Ins.DB.Accounts.Where(p => p.UserName.Equals(username) && p.PassWord.Equals(password)).FirstOrDefault();
                return account;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
            return null;
        }

        public object loadListAccount()
        {
            var db = DataProvider.Ins.DB;

            var data = db.Accounts.Join(
                    db.Employees,
                    account => account.EmployeeID,
                    employee => employee.EmployeeID,
                    (account, employee) =>
                       new
                       {
                           EmployeeId = employee.EmployeeID,
                           DisplayName = employee.Name,
                           Username = account.UserName,
                           Password = account.PassWord,
                           Role = account.Role,
                       }
                    ).ToList();
            return data;

        }

        public List<string> getRoleList()
        {
            List<string> roleList = new List<string>();
            var db = DataProvider.Ins.DB;
            roleList = db.Accounts.GroupBy(a => a.Role).Select(x => x.Key).ToList();
            return roleList;
        }

        public List<string> getEmployeeList()
        {
            List<string> employeeList = new List<string>();
            var db = DataProvider.Ins.DB;
            employeeList = db.Employees.GroupBy(em => em.Name).Select(x => x.Key).ToList();
            return employeeList;
        }

        public bool addAccount(Account account)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateAccount(Account account)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                Account acc = db.Accounts.Where(x => x.UserName == account.UserName).Select(x => x).FirstOrDefault();
                acc.PassWord = account.PassWord;
                acc.Role = account.Role;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool removeAccount(string username)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                Account account = db.Accounts.Where(x => x.UserName == username).FirstOrDefault();
                db.Accounts.Remove(account);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string getEmployeeIdByName(string name)
        {
            string empid = "";
            var db = DataProvider.Ins.DB;
            try
            {
                empid = db.Employees.Where(em => name.Equals(em.Name)).Select(x => x.EmployeeID).FirstOrDefault();
            }
            catch
            {
                return "";
            }
            return empid;
        }
    }
}

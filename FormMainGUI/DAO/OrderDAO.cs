using FormMainGUI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMainGUI.DAO
{
    class OrderDAO
    {
        private static OrderDAO instance;
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null) instance = new OrderDAO();
                return instance;
            }
            set => instance = value;
        }
        private OrderDAO() { }

        public object getListOrder()
        {
            var db = DataProvider.Ins.DB;
            var data = (from o in db.Orders select new { 
                                OrderID = o.OrderID,
                                Date = o.DateOfOrder,                                
                                EmployeeID = o.Employee.EmployeeID,
                                Employee = o.Employee.Name,
                                Total = o.TotalMoney,
                        }).ToList();
            return data;
        }

        public object getListProduct()
        {
            var db = DataProvider.Ins.DB;
            var data = (from p in db.Products
                               select p).ToList();
            return data;
        }

        public object searchProductByName(string name)
        {
            var listProductSearch = (from l in DataProvider.Ins.DB.Products
                                    where l.Name.Trim().Contains(name)
                                    select l).ToList();
            return listProductSearch;
        }
    }
}

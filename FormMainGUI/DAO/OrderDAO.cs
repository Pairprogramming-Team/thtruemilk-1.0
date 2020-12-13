using FormMainGUI.ModelDB;
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

        public object getListOrderDetail()
        {
            var db = DataProvider.Ins.DB;
            var data = (from o in db.OrdersDetails
                        select new {
                            ID = o.OrderDetailID,
                            OrderID = o.Order.OrderID,
                            Name = o.Product.Name,
                            Quantity = o.Quantity,
                            Price = o.Product.Price,
                            Total = o.TotalAmount
                        }).ToList();
            return data;
        }

        public object searchOrderDetailByName(string name)
        {
            var db = DataProvider.Ins.DB;
            var data = (from o in db.OrdersDetails
                        where o.Product.Name.Trim().Contains(name)
                        select new
                        {
                            ID = o.OrderDetailID,
                            OrderID = o.Order.OrderID,
                            Name = o.Product.Name,
                            Quantity = o.Quantity,
                            Price = o.Product.Price,
                            Total = o.TotalAmount
                        }).ToList();
            return data;
        }

        public object searchProductByName(string name)
        {
            var db = DataProvider.Ins.DB;
            var listProductSearch = (from l in db.Products
                                    where l.Name.Trim().Contains(name)
                                    select l).ToList();
            return listProductSearch;
        }

        public object searchOrderByEmployee(string name)
        {
            var db = DataProvider.Ins.DB;
            var listOrderSearch = (from o in db.Orders
                                   where o.Employee.Name.Trim().Contains(name)
                                   select new
                                   {
                                       OrderID = o.OrderID,
                                       Date = o.DateOfOrder,
                                       EmployeeID = o.Employee.EmployeeID,
                                       Employee = o.Employee.Name,
                                       Total = o.TotalMoney,
                                   }).ToList();
            return listOrderSearch;
        }

        public bool addOrderDetail(OrdersDetail ordersDetail)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                db.OrdersDetails.Add(ordersDetail);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool addOrder(Order order)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateProduct(Product product)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                Product product1 = db.Products.Where(x => x.ProductID == product.ProductID).Select(x => x).FirstOrDefault();
                product1.Quantity = product.Quantity;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateOrderByTotalMoney(Order order)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                Order orders = db.Orders.Where(x => x.OrderID == order.OrderID).Select(x => x).FirstOrDefault();
                orders.TotalMoney = order.TotalMoney;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public object getListOrderDetailByOrderID(string id)
        {
            var db = DataProvider.Ins.DB;
            var data = (from o in db.OrdersDetails
                        where o.OrderID == id
                        select new { 
                        ID = o.OrderDetailID,
                        Name = o.Product.Name,
                        Quantity = o.Quantity,
                        Price = o.Product.Price,
                        Total = o.TotalAmount
                        }).ToList();
            return data;
        }

        public bool deleteOrder(string id)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                var ordersDetail = (from o in DataProvider.Ins.DB.OrdersDetails
                                    where o.OrderID == id
                                    select o);
                foreach (var item in ordersDetail)
                {
                    db.OrdersDetails.Remove(item);
                }

                Order order = db.Orders.Where(x => x.OrderID == id).Select(x => x).FirstOrDefault();
                db.Orders.Remove(order);

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool updateOrderDetail(OrdersDetail ordersDetail)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                OrdersDetail ordersDetail1 = db.OrdersDetails.Where(x => x.OrderDetailID == ordersDetail.OrderDetailID).Select(x => x).FirstOrDefault();
                ordersDetail1.Quantity = ordersDetail.Quantity;
                ordersDetail1.TotalAmount = ordersDetail.TotalAmount;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateProductAfterUpdateOD(Product product)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                Product product1 = db.Products.Where(x => x.Name.Equals(product.Name)).Select(x => x).FirstOrDefault();
                product1.Quantity = product.Quantity;
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

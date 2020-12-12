﻿using FormMainGUI.ModelDB;
using FormMainGUI.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace FormMainGUI.DAO
{
    public class ProductsDAO
    {
        private static ProductsDAO instance;
        public static ProductsDAO Instance
        {
            get
            {
                if (instance == null) instance = new ProductsDAO();
                return instance;
            }
            set => instance = value;
        }
        private ProductsDAO() { }
        public object loadListProducts()
        {

            var db = DataProvider.Ins.DB;
            var result = (from c in db.Products
                         join d in db.ProductsDetails
                         on c.ProductID equals d.ProductID
                         select new
                         {
                             ID = c.ProductID,
                             Name = c.Name,
                             Quantity = c.Quantity,
                             Price = c.Price,
                             ProductDetailID = d.ProductDetailID,
                             Status = (d.Status),
                             MFG = d.MFG,
                             EXP = d.EXP,
                             ProductEntryDate = d.ProductEntryDate
                         }
                    ).ToList();
            return result;

        }
        public object Search(string id)
        {

            var db = DataProvider.Ins.DB;
            var result = (from c in db.Products
                          join d in db.ProductsDetails
                          on c.ProductID equals d.ProductID
                          where c.Name.Contains(id)
                          select new
                          {
                              ID = c.ProductID,
                              Name = c.Name,
                              Quantity = c.Quantity,
                              Price = c.Price,
                              ProductDetailID = d.ProductDetailID,
                              Status = (d.Status),
                              MFG = d.MFG,
                              EXP = d.EXP,
                              ProductEntryDate = d.ProductEntryDate
                          }
                    ).ToList();
            return result;

        }
        public List<string> getProductList()
        {
            List<string> productList = new List<string>();
            var db = DataProvider.Ins.DB;
            productList = db.Products.GroupBy(p => p.Name).Select(x => x.Key).ToList();
            return productList;
        }
        public List<string> getStatusList()
        {
            List<string> statusList = new List<string>();
            var db = DataProvider.Ins.DB;
            statusList = db.ProductsDetails.GroupBy(a => a.Status).Select(x => x.Key).ToList();
            return statusList;
        }
        public bool productAdd(Product product,ProductsDetail productsDetail)
        {
            
            var db = DataProvider.Ins.DB;
            try
            {
                
                db.Products.Add(product);
                db.SaveChanges();
                var r = db.Products.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
                string detail = "'" + productsDetail.ProductDetailID + "'" + "," +   productsDetail.Status  + "," + "'" + productsDetail.MFG.Value.ToString("yyyy" + "MM" + "dd") + "'" + "," + "'" + productsDetail.EXP.Value.ToString("yyyy" + "MM" + "dd") + "'" + "," + "'" + productsDetail.ProductEntryDate.Value.ToString("yyyy" + "MM" + "dd") + "'" + "," + "'" + productsDetail.ProductID + "'";
                Console.WriteLine(detail);
                string sqlquery = "INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )" + " Values " + "(" + detail + ")";
                Console.WriteLine(sqlquery);
                int noOfRowInserted = db.Database.ExecuteSqlCommand(sqlquery);
                return true;
            }
            catch
            {
                return false;
            }
        }
 
        public bool updateProduct(Product product, ProductsDetail productsDetail)
        {
            var db = DataProvider.Ins.DB;
            try
            {
                Product r = db.Products.Where(x => x.ProductID == product.ProductID).Select(x => x).FirstOrDefault();
                ProductsDetail d = db.ProductsDetails.Where(y => y.ProductDetailID == productsDetail.ProductDetailID).Select(x => x).SingleOrDefault();
                r.Name = product.Name;
                r.Quantity = product.Quantity;
                r.Price = product.Price;
                d.Status = productsDetail.Status;
                d.MFG = productsDetail.MFG;
                d.EXP = productsDetail.EXP;
                d.ProductEntryDate =productsDetail.ProductEntryDate;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool removeProduct(string id)
        {
            var db = DataProvider.Ins.DB;
            try
            {
              
                ProductsDetail b = db.ProductsDetails.Where(x => x.ProductID == id).FirstOrDefault();
                db.ProductsDetails.Remove(b);
                Product a = db.Products.Where(x => x.ProductID == id).FirstOrDefault();
                db.Products.Remove(a);
                
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

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormMainGUI.ModelDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductsDetail
    {
        public ProductsDetail()
        {

        }
        public ProductsDetail(string text1, string v, DateTime value1, DateTime value2, DateTime value3, string text2)
        {
            this.ProductDetailID = text1;
            this.Status = v;
            this.MFG = value1;
            this.EXP = value2;
            this.ProductEntryDate = value3;
            this.ProductID = text2;
        }
        public string ProductDetailID { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> MFG { get; set; }
        public Nullable<System.DateTime> EXP { get; set; }
        public Nullable<System.DateTime> ProductEntryDate { get; set; }
        public string ProductID { get; set; }
    
        public virtual Product Product { get; set; }
    }
}

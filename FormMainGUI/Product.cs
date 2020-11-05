namespace FormMainGUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductsDetails = new HashSet<ProductsDetail>();
        }

        [StringLength(20)]
        public string ProductID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Quantity { get; set; }

        public decimal? Price { get; set; }

        [StringLength(20)]
        public string OrderDetailID { get; set; }

        public virtual OrdersDetail OrdersDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsDetail> ProductsDetails { get; set; }
    }
}

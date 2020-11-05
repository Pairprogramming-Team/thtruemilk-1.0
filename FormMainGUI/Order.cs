namespace FormMainGUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrdersDetails = new HashSet<OrdersDetail>();
        }

        [StringLength(20)]
        public string OrderID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfOrder { get; set; }

        public decimal? TotalMoney { get; set; }

        [StringLength(20)]
        public string EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}

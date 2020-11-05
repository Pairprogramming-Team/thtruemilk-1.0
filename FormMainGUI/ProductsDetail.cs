namespace FormMainGUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductsDetail")]
    public partial class ProductsDetail
    {
        [Key]
        [StringLength(20)]
        public string ProductDetailID { get; set; }

        [StringLength(100)]
        public string StatusProduct { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MFG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EXP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfProduct { get; set; }

        [StringLength(20)]
        public string ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}

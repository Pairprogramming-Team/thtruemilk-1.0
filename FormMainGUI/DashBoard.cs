namespace FormMainGUI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DashBoard : DbContext
    {
        public DashBoard()
            : base("name=ModelChart")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrdersDetail> OrdersDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductsDetail> ProductsDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.NameAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Passcode)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.NameAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalMoney)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<OrdersDetail>()
                .Property(e => e.OrderDetailID)
                .IsUnicode(false);

            modelBuilder.Entity<OrdersDetail>()
                .Property(e => e.TotalAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrdersDetail>()
                .Property(e => e.OrderID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.OrderDetailID)
                .IsUnicode(false);

            modelBuilder.Entity<ProductsDetail>()
                .Property(e => e.ProductDetailID)
                .IsUnicode(false);

            modelBuilder.Entity<ProductsDetail>()
                .Property(e => e.ProductID)
                .IsUnicode(false);
        }
    }
}

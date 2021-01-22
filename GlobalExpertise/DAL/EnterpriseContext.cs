using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using GlobalExpertise.models;


namespace GlobalExpertise.DAL
{
    class EnterpriseContext : DbContext
    {
        public EnterpriseContext() : base("EnterpriseContext")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Departement> Departements { get; set; }

        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           modelBuilder.Entity<PurchaseOrder>()
              .HasKey(po => new { po.OrderId, po.ProductId });

           modelBuilder.Entity<Order>()
              .HasMany(o => o.PurchaseOrders)
              .WithRequired()
              .HasForeignKey(po => po.OrderId);

            modelBuilder.Entity<Product>()
            .HasMany(p => p.PurchaseOrders)
            .WithRequired()
            .HasForeignKey(po => po.ProductId);
        }

    }




}

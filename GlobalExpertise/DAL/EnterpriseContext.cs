using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace GlobalExpertise.DAL
{
    class EnterpriseContext : DbContext
    {
        public EnterpriseContext() : base("EnterpriseContext")
        {
        }
        public DbSet<models.Employee> Employees { get; set; }
        public DbSet<models.Customer> Customers { get; set; }
        public DbSet<models.Order> Orders { get; set; }
        public DbSet<models.Product> Products { get; set; }
        public DbSet<models.Category> Categories { get; set; }
        public DbSet<models.PurchaseOrder> PurchaseOrders { get; set; }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           modelBuilder.Entity<models.PurchaseOrder>()
              .HasKey(po => new { po.OrderId, po.ProductId });

           modelBuilder.Entity<models.Order>()
              .HasMany(o => o.PurchaseOrders)
              .WithRequired()
              .HasForeignKey(po => po.OrderId);

            modelBuilder.Entity<models.Product>()
            .HasMany(p => p.PurchaseOrders)
            .WithRequired()
            .HasForeignKey(po => po.ProductId);
        }

    }




}

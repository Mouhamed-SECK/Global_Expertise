using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace GlobalExpertise.DAL
{
    class EnterpriseContext : DbContext
    {
        public EnterpriseContext() : base("EnterpriseContext")
        {
        }
        public DbSet<models.Employee> employees { get; set; }
        public DbSet<models.Customer> customers { get; set; }
        public DbSet<models.Order> orders { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }




}

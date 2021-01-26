namespace GlobalExpertise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProductEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "ProductImage", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "ProductImage");
        }
    }
}

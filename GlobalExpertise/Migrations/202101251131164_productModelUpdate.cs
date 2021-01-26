namespace GlobalExpertise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productModelUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Product", "Category_catregoryId", "dbo.Category");
            DropIndex("dbo.Product", new[] { "Category_catregoryId" });
            DropIndex("dbo.PurchaseOrder", new[] { "Product_productId" });
            AddColumn("dbo.Product", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Product", "Category_catregoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Product", "Category_catregoryId");
            CreateIndex("dbo.PurchaseOrder", "Product_ProductId");
            AddForeignKey("dbo.Product", "Category_catregoryId", "dbo.Category", "catregoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Category_catregoryId", "dbo.Category");
            DropIndex("dbo.PurchaseOrder", new[] { "Product_ProductId" });
            DropIndex("dbo.Product", new[] { "Category_catregoryId" });
            AlterColumn("dbo.Product", "Category_catregoryId", c => c.Int());
            DropColumn("dbo.Product", "Name");
            CreateIndex("dbo.PurchaseOrder", "Product_productId");
            CreateIndex("dbo.Product", "Category_catregoryId");
            AddForeignKey("dbo.Product", "Category_catregoryId", "dbo.Category", "catregoryId");
        }
    }
}

namespace GlobalExpertise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderProductCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        catregoryId = c.Int(nullable: false, identity: true),
                        name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.catregoryId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        quantity = c.Int(nullable: false),
                        price = c.Double(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Category_catregoryId = c.Int(),
                    })
                .PrimaryKey(t => t.productId)
                .ForeignKey("dbo.Category", t => t.Category_catregoryId)
                .Index(t => t.Category_catregoryId);
            
            CreateTable(
                "dbo.PurchaseOrder",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        PurchaseOrderId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Order_OrderId = c.Int(),
                        Product_productId = c.Int(),
                    })
                .PrimaryKey(t => new { t.OrderId, t.ProductId })
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.Order_OrderId)
                .ForeignKey("dbo.Product", t => t.Product_productId)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId)
                .Index(t => t.Order_OrderId)
                .Index(t => t.Product_productId);
            
            AlterColumn("dbo.Order", "OrderNumber", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseOrder", "ProductId", "dbo.Product");
            DropForeignKey("dbo.PurchaseOrder", "Product_productId", "dbo.Product");
            DropForeignKey("dbo.PurchaseOrder", "Order_OrderId", "dbo.Order");
            DropForeignKey("dbo.PurchaseOrder", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Product", "Category_catregoryId", "dbo.Category");
            DropIndex("dbo.PurchaseOrder", new[] { "Product_productId" });
            DropIndex("dbo.PurchaseOrder", new[] { "Order_OrderId" });
            DropIndex("dbo.PurchaseOrder", new[] { "ProductId" });
            DropIndex("dbo.PurchaseOrder", new[] { "OrderId" });
            DropIndex("dbo.Product", new[] { "Category_catregoryId" });
            AlterColumn("dbo.Order", "OrderNumber", c => c.String());
            DropTable("dbo.PurchaseOrder");
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}

namespace GlobalExpertise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Product", "Category_catregoryId", "dbo.Category");
            DropIndex("dbo.Product", new[] { "Category_catregoryId" });
            AlterColumn("dbo.Product", "Category_catregoryId", c => c.Int());
            CreateIndex("dbo.Product", "Category_catregoryId");
            AddForeignKey("dbo.Product", "Category_catregoryId", "dbo.Category", "catregoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Category_catregoryId", "dbo.Category");
            DropIndex("dbo.Product", new[] { "Category_catregoryId" });
            AlterColumn("dbo.Product", "Category_catregoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Product", "Category_catregoryId");
            AddForeignKey("dbo.Product", "Category_catregoryId", "dbo.Category", "catregoryId", cascadeDelete: true);
        }
    }
}

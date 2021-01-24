namespace GlobalExpertise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCategoryColName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Category", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Category", "Name", c => c.Int(nullable: false));
        }
    }
}

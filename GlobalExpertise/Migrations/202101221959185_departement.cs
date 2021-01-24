namespace GlobalExpertise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class departement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departement",
                c => new
                    {
                        departementId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.departementId);
            
            AddColumn("dbo.Employee", "Departement_departementId", c => c.Int());
            CreateIndex("dbo.Employee", "Departement_departementId");
            AddForeignKey("dbo.Employee", "Departement_departementId", "dbo.Departement", "departementId");
            DropColumn("dbo.Employee", "Departement");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employee", "Departement", c => c.Int(nullable: false));
            DropForeignKey("dbo.Employee", "Departement_departementId", "dbo.Departement");
            DropIndex("dbo.Employee", new[] { "Departement_departementId" });
            DropColumn("dbo.Employee", "Departement_departementId");
            DropTable("dbo.Departement");
        }
    }
}

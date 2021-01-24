namespace GlobalExpertise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class departementColUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employee", "Departement_departementId", "dbo.Departement");
            DropIndex("dbo.Employee", new[] { "Departement_departementId" });
            RenameColumn(table: "dbo.Employee", name: "Departement_departementId", newName: "DepartementId");
            AlterColumn("dbo.Employee", "DepartementId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee", "DepartementId");
            AddForeignKey("dbo.Employee", "DepartementId", "dbo.Departement", "departementId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "DepartementId", "dbo.Departement");
            DropIndex("dbo.Employee", new[] { "DepartementId" });
            AlterColumn("dbo.Employee", "DepartementId", c => c.Int());
            RenameColumn(table: "dbo.Employee", name: "DepartementId", newName: "Departement_departementId");
            CreateIndex("dbo.Employee", "Departement_departementId");
            AddForeignKey("dbo.Employee", "Departement_departementId", "dbo.Departement", "departementId");
        }
    }
}

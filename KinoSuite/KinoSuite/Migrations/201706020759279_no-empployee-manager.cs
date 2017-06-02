namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class noempployeemanager : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Venue", "Name", c => c.String(maxLength: 40));
            DropTable("dbo.Employee");
            DropTable("dbo.Manager");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Manager",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 60),
                        Surname = c.String(maxLength: 60),
                        CreationDate = c.DateTime(),
                        EMail = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 60),
                        Surname = c.String(maxLength: 60),
                        CreationDate = c.DateTime(),
                        EMail = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.Venue", "Name");
        }
    }
}

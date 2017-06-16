namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedlanguageproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Screening", "Language", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Screening", "Language");
        }
    }
}

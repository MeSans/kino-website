namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adressesstring : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Venue", "Adress", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Venue", "Adress");
        }
    }
}

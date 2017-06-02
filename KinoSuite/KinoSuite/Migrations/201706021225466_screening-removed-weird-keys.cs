namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class screeningremovedweirdkeys : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Screening");
            AddPrimaryKey("dbo.Screening", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Screening");
            AddPrimaryKey("dbo.Screening", new[] { "ID", "MovieId", "VenueId" });
        }
    }
}

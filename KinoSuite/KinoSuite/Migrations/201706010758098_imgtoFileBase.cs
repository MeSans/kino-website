namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imgtoFileBase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "HttpPostedFileBase", c => c.String());
            DropColumn("dbo.Movie", "ImageURL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "ImageURL", c => c.String());
            DropColumn("dbo.Movie", "HttpPostedFileBase");
        }
    }
}

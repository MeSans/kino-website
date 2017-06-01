namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedimgtoURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "ImageURL", c => c.String());
            DropColumn("dbo.Movie", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "Image", c => c.Binary());
            DropColumn("dbo.Movie", "ImageURL");
        }
    }
}

namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imgtoFile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "Img_File", c => c.String());
            DropColumn("dbo.Movie", "HttpPostedFileBase");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "HttpPostedFileBase", c => c.String());
            DropColumn("dbo.Movie", "Img_File");
        }
    }
}

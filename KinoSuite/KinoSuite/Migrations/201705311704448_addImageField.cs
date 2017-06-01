namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addImageField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "Image");
        }
    }
}

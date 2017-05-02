namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class debug : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movie", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.Movie", "Genre", c => c.String());
            AlterColumn("dbo.Movie", "Description", c => c.String());
            AlterColumn("dbo.Movie", "YouTubeLink", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movie", "YouTubeLink", c => c.String(maxLength: 300));
            AlterColumn("dbo.Movie", "Description", c => c.String(maxLength: 200));
            AlterColumn("dbo.Movie", "Genre", c => c.String(maxLength: 60));
            AlterColumn("dbo.Movie", "Title", c => c.String(nullable: false, maxLength: 60));
        }
    }
}

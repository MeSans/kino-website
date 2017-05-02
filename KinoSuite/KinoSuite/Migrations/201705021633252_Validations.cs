namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "Title", c => c.String(nullable: false, maxLength: 60));
            AddColumn("dbo.Movie", "Genre", c => c.String(maxLength: 60));
            AlterColumn("dbo.Employee", "Name", c => c.String(maxLength: 60));
            AlterColumn("dbo.Employee", "Surname", c => c.String(maxLength: 60));
            AlterColumn("dbo.Manager", "Name", c => c.String(maxLength: 60));
            AlterColumn("dbo.Manager", "Surname", c => c.String(maxLength: 60));
            AlterColumn("dbo.Movie", "Description", c => c.String(maxLength: 200));
            AlterColumn("dbo.Movie", "YouTubeLink", c => c.String(maxLength: 300));
            AlterColumn("dbo.Screening", "BasePrice", c => c.Single());
            AlterColumn("dbo.Screening", "SubtitleLanguage", c => c.String(maxLength: 60));
            DropColumn("dbo.Movie", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "Name", c => c.String());
            AlterColumn("dbo.Screening", "SubtitleLanguage", c => c.String());
            AlterColumn("dbo.Screening", "BasePrice", c => c.Int(nullable: false));
            AlterColumn("dbo.Movie", "YouTubeLink", c => c.String());
            AlterColumn("dbo.Movie", "Description", c => c.String());
            AlterColumn("dbo.Manager", "Surname", c => c.String());
            AlterColumn("dbo.Manager", "Name", c => c.String());
            AlterColumn("dbo.Employee", "Surname", c => c.String());
            AlterColumn("dbo.Employee", "Name", c => c.String());
            DropColumn("dbo.Movie", "Genre");
            DropColumn("dbo.Movie", "Title");
        }
    }
}

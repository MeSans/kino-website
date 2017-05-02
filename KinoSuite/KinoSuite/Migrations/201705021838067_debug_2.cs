namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class debug_2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movie", "Title", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Movie", "Genre", c => c.String(maxLength: 60));
            AlterColumn("dbo.Movie", "Description", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movie", "Description", c => c.String());
            AlterColumn("dbo.Movie", "Genre", c => c.String());
            AlterColumn("dbo.Movie", "Title", c => c.String(maxLength: 60));
        }
    }
}

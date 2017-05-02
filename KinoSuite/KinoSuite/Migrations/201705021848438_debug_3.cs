namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class debug_3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movie", "YouTubeLink", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movie", "YouTubeLink", c => c.String());
        }
    }
}

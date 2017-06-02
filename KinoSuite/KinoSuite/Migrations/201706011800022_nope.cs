namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nope : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Screening", "ScreeningStart", c => c.DateTime());
            AlterColumn("dbo.Screening", "ScreeningEnd", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Screening", "ScreeningEnd", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Screening", "ScreeningStart", c => c.DateTime(nullable: false));
        }
    }
}

namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requireddates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Screening", "ScreeningStart", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Screening", "ScreeningEnd", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Screening", "ScreeningEnd", c => c.DateTime());
            AlterColumn("dbo.Screening", "ScreeningStart", c => c.DateTime());
        }
    }
}

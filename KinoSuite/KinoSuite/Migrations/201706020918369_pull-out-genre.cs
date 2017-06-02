namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pulloutgenre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Movie", "Genre_ID", c => c.Int());
            CreateIndex("dbo.Movie", "Genre_ID");
            AddForeignKey("dbo.Movie", "Genre_ID", "dbo.Genres", "ID");
            DropColumn("dbo.Movie", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "Genre", c => c.String(maxLength: 60));
            DropForeignKey("dbo.Movie", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Movie", new[] { "Genre_ID" });
            DropColumn("dbo.Movie", "Genre_ID");
            DropTable("dbo.Genres");
        }
    }
}

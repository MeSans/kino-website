namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        CreationDate = c.DateTime(),
                        EMail = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Manager",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        CreationDate = c.DateTime(),
                        EMail = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(),
                        Rating = c.Int(nullable: false),
                        Description = c.String(),
                        YouTubeLink = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Screening",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ScreeningStart = c.DateTime(),
                        ScreeningEnd = c.DateTime(),
                        BasePrice = c.Int(nullable: false),
                        IsPremiere = c.Boolean(),
                        SubtitleLanguage = c.String(),
                        Movie_ID = c.Int(),
                        Venue_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Movie", t => t.Movie_ID)
                .ForeignKey("dbo.Venue", t => t.Venue_ID)
                .Index(t => t.Movie_ID)
                .Index(t => t.Venue_ID);
            
            CreateTable(
                "dbo.Venue",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Screening", "Venue_ID", "dbo.Venue");
            DropForeignKey("dbo.Screening", "Movie_ID", "dbo.Movie");
            DropIndex("dbo.Screening", new[] { "Venue_ID" });
            DropIndex("dbo.Screening", new[] { "Movie_ID" });
            DropTable("dbo.Venue");
            DropTable("dbo.Screening");
            DropTable("dbo.Movie");
            DropTable("dbo.Manager");
            DropTable("dbo.Employee");
        }
    }
}

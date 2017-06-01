namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Files : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        FileId = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 255),
                        ContentType = c.String(maxLength: 100),
                        Content = c.Binary(),
                        FileType = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FileId)
                .ForeignKey("dbo.Movie", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId);
            
            DropColumn("dbo.Movie", "Img_File");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "Img_File", c => c.String());
            DropForeignKey("dbo.Files", "MovieId", "dbo.Movie");
            DropIndex("dbo.Files", new[] { "MovieId" });
            DropTable("dbo.Files");
        }
    }
}

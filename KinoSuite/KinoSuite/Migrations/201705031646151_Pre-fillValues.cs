namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrefillValues : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Screening", "Movie_ID", "dbo.Movie");
            DropForeignKey("dbo.Screening", "Venue_ID", "dbo.Venue");
            DropIndex("dbo.Screening", new[] { "Movie_ID" });
            DropIndex("dbo.Screening", new[] { "Venue_ID" });
            RenameColumn(table: "dbo.Screening", name: "Movie_ID", newName: "MovieId");
            RenameColumn(table: "dbo.Screening", name: "Venue_ID", newName: "VenueId");
            DropPrimaryKey("dbo.Screening");
            AlterColumn("dbo.Screening", "MovieId", c => c.Int(nullable: false));
            AlterColumn("dbo.Screening", "VenueId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Screening", new[] { "ID", "MovieId", "VenueId" });
            CreateIndex("dbo.Screening", "MovieId");
            CreateIndex("dbo.Screening", "VenueId");
            AddForeignKey("dbo.Screening", "MovieId", "dbo.Movie", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Screening", "VenueId", "dbo.Venue", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Screening", "VenueId", "dbo.Venue");
            DropForeignKey("dbo.Screening", "MovieId", "dbo.Movie");
            DropIndex("dbo.Screening", new[] { "VenueId" });
            DropIndex("dbo.Screening", new[] { "MovieId" });
            DropPrimaryKey("dbo.Screening");
            AlterColumn("dbo.Screening", "VenueId", c => c.Int());
            AlterColumn("dbo.Screening", "MovieId", c => c.Int());
            AddPrimaryKey("dbo.Screening", "ID");
            RenameColumn(table: "dbo.Screening", name: "VenueId", newName: "Venue_ID");
            RenameColumn(table: "dbo.Screening", name: "MovieId", newName: "Movie_ID");
            CreateIndex("dbo.Screening", "Venue_ID");
            CreateIndex("dbo.Screening", "Movie_ID");
            AddForeignKey("dbo.Screening", "Venue_ID", "dbo.Venue", "ID");
            AddForeignKey("dbo.Screening", "Movie_ID", "dbo.Movie", "ID");
        }
    }
}

namespace KinoSuite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class goddmanit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movie", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Movie", new[] { "Genre_ID" });
            RenameColumn(table: "dbo.Movie", name: "Genre_ID", newName: "GenreId");
            AlterColumn("dbo.Movie", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movie", "GenreId");
            AddForeignKey("dbo.Movie", "GenreId", "dbo.Genres", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movie", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movie", new[] { "GenreId" });
            AlterColumn("dbo.Movie", "GenreId", c => c.Int());
            RenameColumn(table: "dbo.Movie", name: "GenreId", newName: "Genre_ID");
            CreateIndex("dbo.Movie", "Genre_ID");
            AddForeignKey("dbo.Movie", "Genre_ID", "dbo.Genres", "ID");
        }
    }
}

namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (NEWID(), 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (NEWID(), 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (NEWID(), 'Country')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (NEWID(), 'Electronic')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Name IN ('Jazz', 'Rock', 'Country', 'Electronic'");
        }
    }
}

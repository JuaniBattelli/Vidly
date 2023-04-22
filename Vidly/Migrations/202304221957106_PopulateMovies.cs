namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (1,'Matrix','Accion', CONVERT(datetime, '1999-03-31 00:00:00', 120), GETDATE(), 5)");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (2,'Star Wars','Ciencia Ficcion', CONVERT(datetime, '1999-12-25 00:00:00', 120), GETDATE(), 6)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}

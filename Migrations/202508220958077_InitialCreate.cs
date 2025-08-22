namespace LibraryDemoWebforms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Books", name: "Author_AuthorID", newName: "AuthorID");
            RenameIndex(table: "dbo.Books", name: "IX_Author_AuthorID", newName: "IX_AuthorID");
            DropColumn("dbo.Books", "AutorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "AutorId", c => c.Int());
            RenameIndex(table: "dbo.Books", name: "IX_AuthorID", newName: "IX_Author_AuthorID");
            RenameColumn(table: "dbo.Books", name: "AuthorID", newName: "Author_AuthorID");
        }
    }
}

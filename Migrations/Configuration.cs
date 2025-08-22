namespace LibraryDemoWebforms.Migrations
{
    using LibraryDemoWebforms.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryDemoWebforms.Data_Layer.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LibraryDemoWebforms.Data_Layer.LibraryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            GetAuthors().ForEach(c => context.Authors.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }
        private static List<Book> GetBooks()
        {
            var books = new List<Book>
            {
                new Book
                {
                    BookId = 1,
                    Title = "Beyond Horizon",
                    Description = "Fiction",
                    AuthorID = 1,
                },

                new Book
                {
                    BookId = 2,
                    Title = "Health Benefits",
                    Description = "Life Style",
                    AuthorID = 2,
                },

                new Book
                {
                    BookId = 3,
                    Title = "Midation Practice",
                    Description = "LifeStyle",
                    AuthorID = 2,
                },
            };
            return books;
        }
        private static List<Author> GetAuthors()
        {
            var Authors = new List<Author>
            {
                new Author
                {
                    AuthorID = 1,
                    Name = "Eintsien",
                },
                new Author
                {
                    AuthorID = 2,
                    Name = "C hook",
                },
            };
            return Authors;
        }
    }
}

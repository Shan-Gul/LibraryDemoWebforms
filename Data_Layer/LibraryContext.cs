using LibraryDemoWebforms.Model;
using System.Data.Entity;

namespace LibraryDemoWebforms.Data_Layer
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryDB")
        {
            // Agar model change ho to database automatically recreate ho jaye
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<LibraryContext>());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}

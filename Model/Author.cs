using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryDemoWebforms.Model
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

    
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryDemoWebforms.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? AuthorID { get; set; }
        public virtual Author Author { get; set; }

         
    }
}
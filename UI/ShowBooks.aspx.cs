using LibraryDemoWebforms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace LibraryDemoWebforms.UI
{
    public partial class ShowBooks : System.Web.UI.Page
    {
        private LibraryDemoWebforms.Data_Layer.LibraryContext _context = new LibraryDemoWebforms.Data_Layer.LibraryContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptBooks.DataSource = GetBooks();
                rptBooks.DataBind();
            }
        }

        public IEnumerable<Book> GetBooks()
        {
            // Sirf wahi Books show hongi jinke Author exist karte hain
            return _context.Books
                           .Include("Author")
                           .Where(b => b.Author != null)
                           .ToList();
        }


        protected void rptBooks_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "SelectBook")
            {
                int bookId = Convert.ToInt32(e.CommandArgument);
                var book = _context.Books.Include("Author").FirstOrDefault(b => b.BookId == bookId);

                if (book != null)
                {
                    lblTitle.Text = book.Title;
                    lblDesc.Text = string.IsNullOrEmpty(book.Description)
                        ? "No description available."
                        : book.Description + " — This book " + book.Title + " gives you valuable insights and knowledge that will surely inspire you.\"\r\n      + \" It has been written with great detail and attention, making it both engaging and informative.\"\r\n      + \" We hope you enjoy reading it and discover something meaningful within its pages.";

                    lblAuthor.Text = book.Author != null ? book.Author.Name : "(Author missing in database)";

                    pnlBookDetails.Visible = true;
                }
            }
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }
    }
}

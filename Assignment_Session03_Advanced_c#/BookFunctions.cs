using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session03_Advanced_c_
{
    internal class BookFunctions
    {
            public static string GetTitle(Book b) => b.Title;

            public static Func<Book, string> GetAuthor = b => b.Author;

            public static BookDelegate GetISBN = delegate (Book b) { return b.ISBN; };

            public static Func<Book, DateTime> GetPublicationDate = b => b.PublicationDate;
        
    }
}

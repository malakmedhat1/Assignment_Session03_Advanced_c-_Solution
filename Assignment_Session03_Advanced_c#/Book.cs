using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session03_Advanced_c_
{

    
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }

        public Book(string title, string author, string isbn, DateTime pubDate)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationDate = pubDate;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}, ISBN: {ISBN}, Published: {PublicationDate.ToShortDateString()}";
        }
    }
}

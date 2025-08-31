using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session03_Advanced_c_
{
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, Func<Book, string> fPtr)
        {
            foreach (Book b in books)
            {
                Console.WriteLine(fPtr(b));
            }
        }

        public static void ProcessBooks(List<Book> books, BookDelegate fPtr)
        {
            foreach (Book b in books)
            {
                Console.WriteLine(fPtr(b));
            }
        }
    }
    }

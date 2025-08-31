namespace Assignment_Session03_Advanced_c_
{
    public delegate string BookDelegate(Book b);

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> library = new List<Book>
        {
            new Book("Clean Code", "Robert C. Martin", "9780132350884", new DateTime(2008, 8, 1)),
            new Book("The Pragmatic Programmer", "Andrew Hunt", "9780201616224", new DateTime(1999, 10, 30)),
            new Book("Design Patterns", "Erich Gamma", "9780201633610", new DateTime(1994, 10, 21))
        };

            Console.WriteLine("=== Titles (User-Defined Delegate) ===");
            LibraryEngine.ProcessBooks(library, new BookDelegate(BookFunctions.GetTitle));

            Console.WriteLine("\n=== Authors (BCL Delegate Func<>) ===");
            LibraryEngine.ProcessBooks(library, BookFunctions.GetAuthor);

            Console.WriteLine("\n=== ISBNs (Anonymous Method) ===");
            LibraryEngine.ProcessBooks(library, BookFunctions.GetISBN);

            Console.WriteLine("\n=== Publication Dates (Lambda Expression) ===");
            foreach (var b in library)
            {
                Console.WriteLine(BookFunctions.GetPublicationDate(b).ToShortDateString());
            }
        }
    }
}

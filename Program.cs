namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            books.Add(new Book("978-3-16-148410-0", "C# Programming", new string[] { "Alice Smith", "Bob Johnson" },new DateTime(2020, 5, 1), 49.99m));
            books.Add(new Book("978-1-23-456789-0", "Advanced C#", new string[] { "Charlie Brown" }, new DateTime(2021, 3, 15), 59.99m));


            Console.WriteLine("User Defined Delegate Datatype");
            LibraryEngine.ProcessBooks(books, new BookDelegate(BookFunctions.GetTitle));

            Console.WriteLine("==============================");

            Console.WriteLine("BCL Delegate");
            Func<Book, string> func = B => string.Join(", ", B.Authors);
            LibraryEngine.ProcessBooks(books, func);

            Console.WriteLine("==============================");

            Console.WriteLine("Anonymous Method (GetISBN)");
            Func<Book, string> anon = delegate (Book B) { return B.ISBN; };
            LibraryEngine.ProcessBooks(books, anon);

            Console.WriteLine("==============================");

            Console.WriteLine("Lambda Expression (GetPublicationDate)");
            Func<Book, string> lambda = B => B.PublicationDate.ToShortDateString();
            LibraryEngine.ProcessBooks(books, lambda);
        }
    }
}

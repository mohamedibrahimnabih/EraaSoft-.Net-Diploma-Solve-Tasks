namespace CSD03_Library_Management_System
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availability { get; set; }

        public Book(string title, string author, string iSBN, bool availability = true) // Default value for construction
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Availability = availability;
        }
    }

    internal class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public Book? SearchBook(string value)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Title.Contains(value) || Books[i].Author.Contains(value))
                {
                    return Books[i];
                }
            }

            return null;
        }

        public bool BorrowBook(string name)
        {
            Book? book = SearchBook(name);
            if (book != null && book.Availability)
            {
                book.Availability = false;

                //Console.WriteLine($"Ok You Can Borrow: \"{book.Title}\" Book..."); // Mark the method return void
                return true;
            }
            else if (book != null && !book.Availability)
            {
                //Console.WriteLine($"Sorry The \"{book.Title}\" Book Already Borrowed..."); // Mark the method return void
                return false;
            }
            else
            {
                // Console.WriteLine("Sorry We Don't Have This Book In Our Library..."); // Mark the method return void
                return false;
            }
        }

        public bool ReturnBook(string name)
        {
            Book? book = SearchBook(name);
            if (book != null && !book.Availability)
            {
                book.Availability = true;

                //Console.WriteLine($"Thank You For Returned \"{book.Title}\" Book"); // Mark the method return void
                return true;
            }
            else if (book != null && book.Availability)
            {
                //Console.WriteLine($"Book wasn't Borrowed: {book.Title}"); // Mark the method return void
                return false;
            }
            else
            {
                // Console.WriteLine("Sorry We Don't Have This Book In Our Library..."); // Mark the method return void
                return false;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library
            Console.WriteLine("======================== To Add Book ============================\n");

            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            // Searching and borrowing books
            Console.WriteLine("\n======================== To Borrow Book ============================\n");

            Console.WriteLine("Searching and borrowing books...");
            library.BorrowBook("Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); // This book is not in the library

            // Returning books
            Console.WriteLine("\n======================== To Return Book ============================");

            Console.WriteLine("\nReturning books...");
            library.ReturnBook("Gatsby");
            library.ReturnBook("Harry Potter"); // This book is not borrowed
        }
    }
}

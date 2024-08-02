using H2OOP;
using H2OOP.Models;
namespace H2OOP;

public class Test
{
    public static void Main()
    {
        Library library = new();

        for (int i = 1; i <= 100; i++)
        {
            Book book = new($"book{i}", $"author{i}");
            library.AddBook(book);

            User user = new($"user{i}");
            library.RegisterUser(user);

            if(i % 2 == 0)
            {
                user.BorrowBook(book);
            }
        }
        Console.WriteLine("All books:");
        foreach (Book book in library.Books)
        {
            Console.WriteLine($"Title: {book.Title} - Author: {book.Author}");
        }
        Console.WriteLine("All users:");
        foreach (User user in library.Users)
        {
            Console.WriteLine($"User name: {user.Name}");
        }


        Console.WriteLine("All available books:");
        foreach(User user in library.Users)
        {
            if(user.BorrowedBooks.Count != 0)
            {
                Console.WriteLine($"{user.Name} borrowed: ");
                foreach(var book in user.BorrowedBooks)
                {
                    Console.WriteLine($"Title: {book.Title} - Author: {book.Author} ISBN: {book.ISBN}");
                }
            }
        }
        Console.WriteLine("Available books");
        foreach(Book book in library.Books)
        {
            if (book.IsAvailable)
            {
                Console.WriteLine($"{book.Title} is available");
            }
        }

        Console.WriteLine("Søg på ISBN: ");
        var ISBN = Console.ReadLine();

        Console.WriteLine(library.FindBookByISBN(ISBN).Title);

        Console.ReadLine();
    }
}

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
        library.DisplayAllBooks(library);
        
        Console.WriteLine("All Borrowed books:");
        library.DisplayAllBorrowedBooks(library);

        Console.WriteLine("Available books");
        library.DisplayAllAvailableBooks(library);

        Console.WriteLine("Søg på ISBN: ");
        var ISBN = Console.ReadLine();

        Console.WriteLine(library.FindBookByISBN(ISBN).Title);

        Console.ReadLine();
    }
}

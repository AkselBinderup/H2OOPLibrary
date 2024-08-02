using H2OOP.Models;

namespace H2OOP;

public class Library
{
    public List<Book> Books { get; set; } = [];
    public List<User> Users { get; set; } = [];

    public void AddBook(Book book) => Books.Add(book);
    public void RemoveBook(Book book) => Books.Remove(book);
    public void RegisterUser(User user) => Users.Add(user);
    public void DisplayAllBooks(Library library)
    {
        foreach (Book book in library.Books)
        {
            Console.WriteLine($"Title: {book.Title} - Author: {book.Author}");
        }
    }
    public void DisplayAllAvailableBooks(Library library)
    {
        foreach (Book book in library.Books)
        {
            if (book.IsAvailable)
            {
                Console.WriteLine($"{book.Title} is available");
            }
        }
    }
    public void DisplayAllBorrowedBooks(Library library)
    {
        foreach (User user in library.Users)
        {
            if (user.BorrowedBooks.Count != 0)
            {
                Console.WriteLine($"{user.Name} borrowed: ");
                foreach (var book in user.BorrowedBooks)
                {
                    Console.WriteLine($"Title: {book.Title} - Author: {book.Author} ISBN: {book.ISBN}");
                }
            }
        }
    }
    public Book FindBookByISBN(string? ISBN) => Books.First(x => x.ISBN.Equals(ISBN));
    
}

using H2OOP.Models;

namespace H2OOP;

public class Library
{
    public List<Book> Books { get; set; } = [];
    public List<User> Users { get; set; } = [];

    public void AddBook(Book book) => Books.Add(book);
    public void RemoveBook(Book book) => Books.Remove(book);
    public void RegisterUser(User user) => Users.Add(user);
    public void DisplayAllBooks() 
    {
        foreach (Book book in Books)
        {
            //senere
            Console.WriteLine(book);
        }
    }
    public void DisplayAllAvailableBooks() 
    {
        foreach(Book book in Books)
        {
            if(book.IsAvailable)
                Console.WriteLine(book);
        }
    }
    public Book FindBookByISBN(string? ISBN) => Books.First(x => x.ISBN.Equals(ISBN));
    
}

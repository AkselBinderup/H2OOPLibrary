using H2OOP;
using H2OOP.Models;

namespace H2OOPXUnitTest;

public class UnitTestLibrary
{
    [Fact]
    public void TestRegisterUser()
    {
        Library library = new Library();
        User user1 = new("Lars");
        User user2 = new("Per");
        library.RegisterUser(user1);
        library.RegisterUser(user2);
        Assert.True(library.Users.Count is 2);
        
    }
    [Fact]
    public void TestFindBook()
    {
        Library library = new Library();
        Book book1 = new("The Lord Of The Flies", "William Golding");
        Book book2 = new("Metamorphosis", "Franz Kafka");
        library.AddBook(book1);
        library.AddBook(book2);

        Assert.True(library.Books.Count is 2);
        Assert.True(library.FindBookByISBN(book1.ISBN).Title is not "");
        Assert.True(library.FindBookByISBN(book2.ISBN).Title is not "");

        Assert.True(library.FindBookByISBN(book1.ISBN).Title is "The Lord Of The Flies");
        Assert.True(library.FindBookByISBN(book1.ISBN).Author is "William Golding");

        Assert.True(library.FindBookByISBN(book2.ISBN).Title is "Metamorphosis");
        Assert.True(library.FindBookByISBN(book2.ISBN).Author is "Franz Kafka");

        library.RemoveBook(book1);
        Assert.Throws<InvalidOperationException>(() => library.FindBookByISBN(book1.ISBN).Title is "The Lord Of The Flies");
        Assert.Throws<InvalidOperationException>(() => library.FindBookByISBN(book1.ISBN).Author is "William Golding");
        Assert.True(library.Books.Count is 1);

    }
}


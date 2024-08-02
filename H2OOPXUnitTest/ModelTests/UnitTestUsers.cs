using H2OOP;
using H2OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2OOPXUnitTest;

public class UnitTestUsers
{
    [Fact]
    public void TestReturnAndBorrowBook()
    {
        User user = new User("Malthe");
        Book book = new Book("The Idiot", "Fyodor Dostoevsky");
        var bookBorrowed = user.BorrowBook(book);

        Assert.True(!bookBorrowed.IsAvailable);
        Assert.True(user.BorrowedBooks.Count is 1);

        var bookReturned = user.ReturnBook(bookBorrowed);

        Assert.True(bookReturned.IsAvailable);
        Assert.True(user.BorrowedBooks.Count is 0);
    }
    [Fact]
    public void TestDisplayBorrowedBooks()
    {
        Book newBook = new("Animal Farm", "George Orwell");
        Book newBook2 = new("1984", "George Orwell");

        User user = new("George");
        user.BorrowBook(newBook);

        Assert.True(user.BorrowedBooks.Count is 1);
        Assert.Equal(user.BorrowedBooks.Select(x => x.Title).First(), newBook.Title);

        user.BorrowBook(newBook2);
        Assert.True(user.BorrowedBooks.Count is 2);
        Assert.Equal(user.BorrowedBooks.Select(x => x.Title).Last(), newBook2.Title);
        for (int i = 1; i <= 6; i++)
        {
            Book book = new(i.ToString(), i.ToString());
            user.BorrowBook(book);
        }
        Assert.True(user.BorrowedBooks.Count is 5);
    }
    [Fact]
    public void TestDisplayBorrowedBooksPremium()
    {
        PremiumUser user = new("Homer");
        for (int i = 1; i <= 6; i++)
        {
            Book book = new(i.ToString(), i.ToString());
            user.BorrowBook(book);
        }
        Assert.True(user.BorrowedBooks.Count is 6);
    }
}

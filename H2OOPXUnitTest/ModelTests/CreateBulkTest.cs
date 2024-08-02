using H2OOP;

namespace H2OOPXUnitTest.ModelTests;

public class CreateBulkTest
{
    [Fact]
    public void TestBulkBooks()
    {
        Library library = new();

        for(int i = 1; i <= 100; i++)
        {
            Book book = new($"book{i}", $"author{i}");
            library.AddBook(book);
        }
        
        Assert.True(library.Books.Count == 100);
        Assert.True(library.Books.First().Title == "book1" && library.Books.First().Author == "author1");
    }
}

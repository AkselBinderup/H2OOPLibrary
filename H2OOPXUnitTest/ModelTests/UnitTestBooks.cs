using H2OOP;

namespace H2OOPXUnitTest
{
    public class UnitTestBooks
    {
        [Fact]
        public void TestDisplayBooks()
        {
            Book book = new("Moby Dick", "Herman Melville");
            Assert.NotNull(book);
            Assert.True(book.IsAvailable);
            Assert.NotNull(book.ISBN);
            Assert.True(book.ISBN.Length is 13);
            Assert.True(book.Title is "Moby Dick" && book.Author is "Herman Melville");
            var title = $"Title: Moby Dick, Author: Herman Melville, ISBN: {book.ISBN}, IsAvailable: Available";
            Assert.True(book.DisplayInfo() == title);
        }
    }
}
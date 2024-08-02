using System.Xml;

namespace H2OOP.Models
{
    public class User(string? name)
    {
        public string? Name { get; set; } = name;
        public string? UserId { get; set; } = Guid.NewGuid().ToString();
        public List<Book> BorrowedBooks { get; set; } = [];
        public ushort MaximumAllowedBooks { get; set; } = 5;

        public Book BorrowBook(Book book)
        {
            book.ChangeAvailability();
            if(BorrowedBooks.Count < MaximumAllowedBooks) 
                BorrowedBooks.Add(book);

            return book;
        }
        public Book ReturnBook(Book book) 
        {
            book.ChangeAvailability();
            BorrowedBooks.Remove(book);

            return book;
        }
        //Todo: find lige ud af hvordan det skal udskrives takker
        public List<Book> DisplayBorrowedBooks() => BorrowedBooks;

    }
}

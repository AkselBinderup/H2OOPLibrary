using System.Reflection;
using System.Xml;

namespace H2OOP;
public class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string ISBN { get; private set; } = new Random().NextInt64(1000000000000, 9999999999999).ToString();
    public bool IsAvailable { get; private set; } = true;
    public Book(string? title, string? author)
    {
        Title = title;
        Author = author;
    }
    public void ChangeAvailability()
    {
        IsAvailable = !IsAvailable;
    }
    public string DisplayInfo()
    {
        var status = IsAvailable ? "Available" : "Not available";
        return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, IsAvailable: {status}";
    }

}

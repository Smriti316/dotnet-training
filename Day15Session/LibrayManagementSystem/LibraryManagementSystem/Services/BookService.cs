using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Services;

public class BookService : IBookServices
{
    public void AddBooks(Book books)
    {
        Console.Write("hello");
    }

    public void EditBooks(Book books)
    {
        throw new NotImplementedException();
    }

    public void DeleteBooks(int id)
    {
        throw new NotImplementedException();
    }

    public List<Book> ViewAllBooks()
    {
        throw new NotImplementedException();
    }

    public List<Book> SearchBook(string searchParam)
    {
        throw new NotImplementedException();
    }
}
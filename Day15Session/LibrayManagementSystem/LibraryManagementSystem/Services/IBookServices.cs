using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Services;

public interface IBookServices
{
    void AddBooks(Book books); 
    void EditBooks(Book books);
    void DeleteBooks(int id);
    List<Book> ViewAllBooks();
    List<Book> SearchBook(string searchParam);
}
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Repository.BookRepository
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        void EditBook(Book book);
        void DeleteBook(int id);
        List<Book> ViewAllBooks();
        List<Book> SearchBooks(string searchParam);
    }
}

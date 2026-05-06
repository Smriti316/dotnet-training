using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Repository.BookRepository
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        bool EditBook(Book book);
        bool DeleteBook(int id);
        List<Book> ViewAllBooks();
        List<Book> SearchBooks(string searchParam);
        bool UpdateBookCount(Book book);
    }
}

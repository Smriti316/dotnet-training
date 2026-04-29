using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Repository.BookRepository
{
    public interface IBookRepository
    {
        void AddBooks(Book books);
        void EditBooks(Book books);
        void DeleteBooks(int id);
        List<Book> ViewAllBooks();
        List<Book> SearchBook(string searchParam);
    }
}

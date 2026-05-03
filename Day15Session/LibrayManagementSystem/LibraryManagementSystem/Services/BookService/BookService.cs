using LibraryManagementSystem.Model;
using LibraryManagementSystem.Repository.BookRepository;

namespace LibraryManagementSystem.Services.BookService;

/// <summary>
/// Provides operations for managing books, including adding, editing, deleting, viewing, and searching book records.
/// </summary>
/// <remarks>This service defines the contract for book management functionality in the application.
/// Implementations are responsible for handling the underlying data storage and retrieval. Thread safety and
/// performance characteristics depend on the specific implementation.</remarks>
public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    /// <summary>
    /// Adds a book to the collection.
    /// </summary>
    /// <param name="book">The book to add to the collection. Cannot be null.</param>
    public void AddBooks(Book book)
    {
        book.CreatedDate = DateTime.Now;
        book.CreatedBy = "admin";
        _bookRepository.AddBook(book);
    }

    public bool EditBooks(Book book)
    {
        book.ModifiedBy = "admin";
        book.ModifiedDate = DateTime.Now;
        return _bookRepository.EditBook(book);
        //var hasBookBeenEdited =  _bookRepository.EditBook(book);
        //return hasBookBeenEdited;
    }

    public bool DeleteBooks(int id)
    {
        return _bookRepository.DeleteBook(id);
    }

    /// <summary>
    /// Retrieves a list of all books available in the collection.
    /// </summary>
    /// <returns>A list of <see cref="Book"/> objects representing all books. The list is empty if no books are available.</returns>
    public List<Book> ViewAllBooks()
    {
        var bookDetails = _bookRepository.ViewAllBooks();
        return bookDetails;
    }

    public List<Book> SearchBook(string searchParam)
    {
        return _bookRepository.SearchBooks(searchParam);
    }
}
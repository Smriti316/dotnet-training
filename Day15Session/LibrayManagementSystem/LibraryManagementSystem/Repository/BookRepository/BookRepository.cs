using LibraryManagementSystem.Model;
using System.Text.Json;

namespace LibraryManagementSystem.Repository.BookRepository
{
    public class BookRepository : IBookRepository
    {
        private readonly string _connectionString = "../../../Data/book.json";
        public void AddBooks(Book book)
        {
            var bookDetails = GetAllBooksForOperation();

            int BookMaxId = bookDetails.Max(b => b.BookId);
            book.BookId = BookMaxId + 1;

            bookDetails.Add(book);
            var bookString = JsonSerializer.Serialize(bookDetails, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_connectionString, bookString);
        }

        public void DeleteBooks(int id)
        {
            var bookDetails = GetAllBooksForOperation(); bookDetails.RemoveAll(b => b.BookId == id);
            var bookString = JsonSerializer.Serialize(bookDetails, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_connectionString, bookString);
        }

        public void EditBooks(Book books)
        {
            var bookDetails = GetAllBooksForOperation();
            int BookMaxId = bookDetails.Max(b => b.BookId);
            var bookToEdit = bookDetails.FirstOrDefault(b => b.BookId == books.BookId);
            bookToEdit.BookId = BookMaxId + 1;
            bookToEdit.Name = books.Name;
            bookDetails.Add(bookToEdit);
            var bookString = JsonSerializer.Serialize(bookDetails, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_connectionString, bookString);

            var bookDetailsUpdated = GetAllBooksForOperation();
            bookDetailsUpdated.RemoveAll(b => b.BookId == BookMaxId);
            var bookStringUpdated = JsonSerializer.Serialize(bookDetailsUpdated, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_connectionString, bookStringUpdated);
        }

        public List<Book> SearchBook(string searchParam)
        {
            throw new NotImplementedException();
        }

        public List<Book> ViewAllBooks()
        {
            return GetAllBooksForOperation(); 
        }


        private List<Book> GetAllBooksForOperation()
        {
            var bookFromTable = File.ReadAllText(_connectionString);
            var bookDetails = JsonSerializer.Deserialize<List<Book>>(bookFromTable);
            return bookDetails ?? new List<Book>();
        }
    }
}

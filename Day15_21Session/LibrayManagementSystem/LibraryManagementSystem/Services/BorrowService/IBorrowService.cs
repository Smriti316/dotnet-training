namespace LibraryManagementSystem.Services.BorrowService
{
    public interface IBorrowService
    {
        (bool isSuccess, string message)  BorrowBook(int bookId, int memberId);
        double BorrowFine(int bookId, int memberId);
        (bool isSuccess, string message) DueDateManagement(int recordId);
        (bool isSuccess, string message) ReturnBook(int recordId);
    }
}

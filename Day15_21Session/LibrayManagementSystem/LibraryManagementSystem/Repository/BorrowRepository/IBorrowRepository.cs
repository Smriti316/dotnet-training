using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Repository.BorrowRepository
{
    public interface IBorrowRepository
    {
        void BorrowBook(int bookId, int memberId);
        
        double BorrowFine(int bookId, int memberId, int noOfDaysExceeded);
        bool ReturnBook(Borrow borrow);
        List<Borrow> ViewAllBorrowLists();
        bool DueDateManagement(Borrow borrow);
    }
}

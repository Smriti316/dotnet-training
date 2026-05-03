using LibraryManagementSystem.Model;
using LibraryManagementSystem.Repository.BookRepository;
using LibraryManagementSystem.Repository.BorrowRepository;
using LibraryManagementSystem.Repository.MemberRepository;

namespace LibraryManagementSystem.Services.BorrowService
{
    public class BorrowService : IBorrowService
    {
        private readonly IBorrowRepository _borrowRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IMemberRepository _memberRepository;

        public BorrowService(IBorrowRepository borrowRepository, IBookRepository bookRepository, IMemberRepository memberRepository)
        {
            _borrowRepository = borrowRepository;
            _bookRepository = bookRepository;
            _memberRepository = memberRepository;
        }

        public bool BorrowBook(int bookId, int memberId)
        {
            //***member id should be valid
            //***book id should be valid
            //***book count should be greater than 0
            //**membership validity should be valid
            //same member id cannont take same book

            var memberList = _memberRepository.ViewAllMembers();
            var memberDetails = memberList.FirstOrDefault(m => m.MemberId == memberId);
            if (memberDetails.ExpirationDate < DateTime.Now)
            {
                return false;
            }
            var bookList = _bookRepository.ViewAllBooks();
            bool doesMemberExist = memberList.Any(m => m.MemberId == memberId);
            bool doesBookExist = bookList.Any(m => m.BookId == bookId);
            if(doesBookExist && doesMemberExist)
            {
                var bookDetails = bookList.FirstOrDefault(b => b.BookId == bookId);
                var availableCopies = bookDetails?.AvailableCopies;
                if(availableCopies > 0)
                {
                    var bookToEdit = new Book
                    {
                        BookId = bookId,
                        AvailableCopies = (int)(availableCopies - 1),
                        ModifiedBy = "admin",
                        ModifiedDate = DateTime.Now
                    };
                    var isBookUpdated = _bookRepository.UpdateBookCount(bookToEdit);
                    if (isBookUpdated)
                    {
                        _borrowRepository.BorrowBook(bookId, memberId);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public double BorrowFine(int bookId, int memberId, int noOfDaysExceeded)
        {
            throw new NotImplementedException();
        }

        public void DueDateManagement(int bookId, int memberId, DateTime dueDate)
        {
            throw new NotImplementedException();
        }

        public void ReturnBook(int bookId, int memberId)
        {
            throw new NotImplementedException();
        }
    }
}

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

        public (bool isSuccess, string message) BorrowBook(int bookId, int memberId)
        {
            var memberList = _memberRepository.ViewAllMembers();
            var memberDetails = memberList.FirstOrDefault(m => m.MemberId == memberId);
            if (memberDetails?.ExpirationDate < DateTime.Now)
            {
                return (false, "The member with this id has an expired membership, so they cannot borrow books");
            }
            var bookList = _bookRepository.ViewAllBooks();
            bool doesMemberExist = memberList.Any(m => m.MemberId == memberId);
            bool doesBookExist = bookList.Any(m => m.BookId == bookId);
            if(doesBookExist && doesMemberExist)
            {
                var borrowList = _borrowRepository.ViewAllBorrowLists();
                var hasMemberTakenSameBook = borrowList.Any(x => x.BookId == bookId & x.MemberId == memberId & x.Status == "Borrowed");
                if(hasMemberTakenSameBook)
                {
                    return (false, "The member with this id has already taken the same book, so they cannot borrow the same book again");
                }
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
                        return (true, "Book borrowed successfully");
                    }
                    else
                    {
                        return (false, "The book count is not updated successfully, so the borrow process cannot be completed");
                    }
                }
                else
                {
                    return (false, "The book with this id is not available, so the member cannot borrow this book");
                }
            }
            else
            {
                return (false, "Either the book does not exist or the member does not exist, so the borrow process cannot be completed");
            }
        }

        public double BorrowFine(int bookId, int memberId)
        {
            var borrowList = _borrowRepository.ViewAllBorrowLists();
            var bookDetails = borrowList.FirstOrDefault(x => x.BookId == bookId & x.MemberId == memberId);
            if (bookDetails == null)
            {
                return 0;
            }
            else
            {
                int noOfDaysLate = (DateTime.Now - bookDetails.DueDate).Days;
                if (noOfDaysLate > 0)
                {
                    return _borrowRepository.BorrowFine(bookId, memberId, noOfDaysLate);
                }
                return 0;
            }

        }
        
        public (bool isSuccess, string message) ReturnBook(int recordId)
        {
            var bookBorrowList = _borrowRepository.ViewAllBorrowLists();
            var bookBorrowDetails = bookBorrowList.FirstOrDefault(x => x.RecordId == recordId & x.Status == "Borrowed");
            if(bookBorrowDetails is null)
            {
                return (false, "No details found with the given record id or the book has already been returned.");
            }
            else
            {
                bookBorrowDetails.Status = "Returned";
                bookBorrowDetails.ModifiedBy = "admin";
                bookBorrowDetails.ModifiedDate =DateTime.Now;
                bookBorrowDetails.ReturnedDate =DateTime.Now;
                bookBorrowDetails.LateFine = BorrowFine(bookBorrowDetails.BookId, bookBorrowDetails.MemberId);
                var returnBookResponse = _borrowRepository.ReturnBook(bookBorrowDetails);
                if (returnBookResponse)
                {
                    var bookList = _bookRepository.ViewAllBooks();
                    var bookDetails = bookList.FirstOrDefault(b => b.BookId == bookBorrowDetails.BookId);
                    var availableCopies = bookDetails?.AvailableCopies??0;
                    
                    var bookToEdit = new Book
                    {
                        BookId = bookBorrowDetails.BookId,
                        AvailableCopies = availableCopies + 1,
                        ModifiedBy = "admin",
                        ModifiedDate = DateTime.Now
                    };
                    var isBookUpdated = _bookRepository.UpdateBookCount(bookToEdit);
                    if (isBookUpdated)
                    {
                        return (true, "Book returned successfully");
                    }
                    else
                    {
                        return (false, "The book count is not updated successfully, so the return process cannot be completed");
                    }
                }
                else
                {
                    return (false, "Book return failed!");
                }
            }
        }
        
        public void DueDateManagement(int recordId)
        {
            throw new NotImplementedException();
        }
    }
}

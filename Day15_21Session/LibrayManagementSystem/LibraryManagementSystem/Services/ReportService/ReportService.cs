using LibraryManagementSystem.Enums;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Model.Report;
using LibraryManagementSystem.Repository.BookRepository;
using LibraryManagementSystem.Repository.BorrowRepository;
using LibraryManagementSystem.Repository.MemberRepository;

namespace LibraryManagementSystem.Services.ReportService
{
    public class ReportService : IReportService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IBorrowRepository _borrowRepository;
        private readonly IMemberRepository _memberRepository;

        public ReportService(IBookRepository bookRepository, IBorrowRepository borrowRepository, IMemberRepository memberRepository)
        {
            _bookRepository = bookRepository;
            _borrowRepository = borrowRepository;
            _memberRepository = memberRepository;
        }

        public List<Borrow> GetCurrentlyBorrowedBooksReport(BorrowedReportFilter borrowedReportFilter)
        {
            List<Borrow> borrowList = new List<Borrow>();
            var borrowedBooks = _borrowRepository.ViewAllBorrowLists();
            var borrowDetails = borrowedBooks.Where(x => x.MemberId == borrowedReportFilter.MemberId).ToList();
            borrowList.AddRange(borrowDetails);
            return borrowList;
        }

        public List<BorrowedReport> GetBorrowedBooksReport(BorrowedReportFilter borrowedReportFilter)
        {
            List<BorrowedReport> borrowedReports = new List<BorrowedReport>();
            var borrowedBooks = _borrowRepository.ViewAllBorrowLists();
            var memberDetails = _memberRepository.ViewAllMembers();
            var bookDetails = _bookRepository.ViewAllBooks();
            var response = (
                    from b in borrowedBooks
                    join m in memberDetails on b.MemberId equals m.MemberId
                    select new
                    {
                        m.MemberId,
                        m.MemberName,
                        m.MembershipType,
                        m.Phone
                    }
                ).ToList();

            foreach (var details in response.Distinct())
            {
                var borrowedBookDetails =
                    borrowedBooks.Where(x => x.MemberId == details.MemberId).ToList();

                List<BorrowedBookDetail> bookBorrowedDetails = (
                    from b in borrowedBookDetails
                    join bk in bookDetails on b.BookId equals bk.BookId
                    select new BorrowedBookDetail
                    {
                        BookId = bk.BookId,
                        BookName = bk.Name,
                        BookIsbn = bk.Isbn
                    }).ToList();

                BorrowedReport report = new BorrowedReport
                {
                    MemberName = details.MemberName,
                    MembershipType = details.MembershipType,
                    MemberPhoneNumber = details.Phone,
                    BorrowedBookDetails = bookBorrowedDetails
                };
                borrowedReports.Add(report);
            }
            return borrowedReports;
        }

        public List<DueDateReport> GetOverDueBooksReport()
        {
            var borrowedBooks = _borrowRepository.ViewAllBorrowLists();
            var memberDetails = _memberRepository.ViewAllMembers();
            var bookDetails = _bookRepository.ViewAllBooks();
            var dueDateReport = (
                from b in borrowedBooks
                join m in memberDetails on b.MemberId equals m.MemberId
                join bk in bookDetails on b.BookId equals bk.BookId
                where b.Status != BorrowedStatusEnum.Returned & b.DueDate <= DateTime.Now
                select new DueDateReport
                {
                    BookName = bk.Name,
                    MemberName = m.MemberName,
                    MemberPhoneNumber = m.Phone,
                    IssuedDate = DateOnly.FromDateTime(b.CreatedDate),
                    DueDays = (DateTime.Now - b.DueDate).Days,
                    TotalFine = (DateTime.Now - b.DueDate).Days * 0.5
                }).ToList();
            return dueDateReport;
        }

        public MemberHistoryReport MemberHistoryReport(int memberId)
        {
            var memberHistoryReport = new MemberHistoryReport();
            var borrowedBooks = _borrowRepository.ViewAllBorrowLists().Where(x => x.MemberId == memberId).ToList();
            var memberDetails = _memberRepository.ViewAllMembers().FirstOrDefault(x => x.MemberId == memberId);
            var bookDetails = _bookRepository.ViewAllBooks();

            if (memberDetails == null)
            {
                return memberHistoryReport;
            }

            //var memberHistoryReport = new MemberHistoryReport
            //{
            //    MemberName = memberDetails.MemberName,
            //    MemberPhoneNumber = memberDetails.Phone,
            //    JoinedDate = memberDetails.CreatedDate,
            //    MemberEmail = memberDetails.Email,
            //    MemberShipType = memberDetails.MembershipType,
            //    MemberStatus = memberDetails.Status
            //};
            memberHistoryReport.MemberName = memberDetails.MemberName;
            memberHistoryReport.MemberPhoneNumber = memberDetails.Phone;
            memberHistoryReport.JoinedDate = memberDetails.CreatedDate;
            memberHistoryReport.MemberEmail = memberDetails.Email;
            memberHistoryReport.MemberShipType = memberDetails.MembershipType;
            memberHistoryReport.MemberStatus = memberDetails.Status;


            //public string BookName { get; set; }
            //public DateTime IssuedDate { get; set; }
            //public DateTime DueDate { get; set; }
            //public DateTime ReturnedDate { get; set; }
            //public double LateFine { get; set; }
            //public string Status { get; set; }

            List<MemberBookHistory> memberBookList = (
                    from b in borrowedBooks
                    join bk in bookDetails on b.BookId equals bk.BookId
                    select new MemberBookHistory
                    {
                        BookName = bk.Name,
                        IssuedDate = b.CreatedDate,
                        DueDate = b.DueDate,
                        ReturnedDate = b.ReturnedDate,
                        LateFine = b.LateFine,
                        Status = b.Status
                    }).ToList();

            memberHistoryReport.MemberBookHistories = memberBookList;
            return memberHistoryReport;
        }
    }
}
